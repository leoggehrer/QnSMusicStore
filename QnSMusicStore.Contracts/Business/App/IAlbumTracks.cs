using QnSMusicStore.Contracts.Persistence.App;

namespace QnSMusicStore.Contracts.Business.App
{
    public partial interface IAlbumTracks : IRelation<IAlbum, ITrack>, ICopyable<IAlbumTracks>
    {
    }
}
