using QnSMusicStore.Contracts.Persistence.App;

namespace QnSMusicStore.Contracts.Business.App
{
    public partial interface IArtistAlbums : IOneToMany<IArtist, IAlbum>, ICopyable<IArtistAlbums>
    {
    }
}
