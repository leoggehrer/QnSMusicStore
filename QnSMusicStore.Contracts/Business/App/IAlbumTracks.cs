using QnSMusicStore.Contracts.Persistence.App;

namespace QnSMusicStore.Contracts.Business.App
{
    public partial interface IAlbumTracks : IOneToMany<IAlbum, ITrack>, ICopyable<IAlbumTracks>
    {
    }
}
