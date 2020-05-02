using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonBase.Helpers;
using AccountManager = QnSMusicStore.Adapters.Modules.Account.AccountManager;

namespace QnSMusicStore.ConApp
{
    partial class Program
    {
        static partial void EndExecuteMain()
        {
            AsyncHelper.RunSync(() => ImportCsvData());
        }
        private static async Task ImportCsvData()
        {
            var accMngr = new AccountManager();
            var login = await accMngr.LogonAsync(AaEmail, AaPwd);
            var genreCtrl = Adapters.Factory.Create<Contracts.Persistence.App.IGenre>(login.SessionToken);
            var artistCtrl = Adapters.Factory.Create<Contracts.Persistence.App.IArtist>(login.SessionToken);
            var albumTracksCtrl = Adapters.Factory.Create<Contracts.Business.App.IAlbumTracks>(login.SessionToken);
            var genreData = File.ReadAllLines("Genre.csv", Encoding.Default).Skip(1).Select(l =>
            {
                var data = l.Split(';');
                return new { Id = Int32.Parse(data[0]), Name = data[1] };
            });
            var artistData = File.ReadAllLines("Artist.csv", Encoding.Default).Skip(1).Select(l =>
            {
                var data = l.Split(';');
                return new { Id = Int32.Parse(data[0]), Name = data[1] };
            });
            var albumData = File.ReadAllLines("Album.csv", Encoding.Default).Skip(1).Select(l =>
            {
                var data = l.Split(';');
                return new { Id = Int32.Parse(data[0]), Title = data[1], ArtistId = Int32.Parse(data[2]) };
            });
            var trackData = File.ReadAllLines("Track.csv", Encoding.Default).Skip(1).Select(l =>
            {
                var data = l.Split(';');
                return new { Id = Int32.Parse(data[0]), Title = data[1], AlbumId = Int32.Parse(data[2]), GenreId = Int32.Parse(data[3]), Composer = data[4].Equals("<NULL>") ? null : data[4], Milliseconds = Int32.Parse(data[5]), Bytes = Int32.Parse(data[6]), UnitPrice = Double.Parse(data[7]) };
            });
            var genres = new List<Contracts.Persistence.App.IGenre>();
            var artists = new List<Contracts.Persistence.App.IArtist>();

            // import genre
            foreach (var item in genreData)
            {
                var entity = await genreCtrl.CreateAsync();

                entity.Name = item.Name;
                entity = await genreCtrl.InsertAsync(entity);
                genres.Add(entity);
            }

            // import artist
            foreach (var item in artistData)
            {
                var entity = await artistCtrl.CreateAsync();

                entity.Name = item.Name;
                entity = await artistCtrl.InsertAsync(entity);
                artists.Add(entity);
            }

            // import album and tracks
            foreach (var item in albumData)
            {
                var entity = await albumTracksCtrl.CreateAsync();

                entity.FirstItem.Title = item.Title;
                entity.FirstItem.ArtistId = artists[artistData.Select((i, idx) => new { i.Id, idx }).First(i => i.Id == item.ArtistId).idx].Id;

                foreach (var subitem in trackData.Where(i => i.AlbumId == item.Id))
                {
                    var track = entity.CreateSecondItem();

                    track.Title = subitem.Title;
                    track.GenreId = genres[genreData.Select((i, idx) => new { i.Id, idx }).First(i => i.Id == subitem.GenreId).idx].Id;
                    track.Composer = subitem.Composer;
                    track.Milliseconds = subitem.Milliseconds;
                    track.Bytes = subitem.Bytes;
                    track.UnitPrice = subitem.UnitPrice;
                    entity.AddSecondItem(track);
                }
                try
                {
                    entity = await albumTracksCtrl.InsertAsync(entity);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            await accMngr.LogoutAsync(login.SessionToken);
        }
    }
}
