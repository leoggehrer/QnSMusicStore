using QnSMusicStore.Contracts.Persistence.App;

namespace QnSMusicStore.Contracts.Business.App
{
    public partial interface IArtistAlbums : IRelation<IArtist, IAlbum>, ICopyable<IArtistAlbums>
    {
    }
}
