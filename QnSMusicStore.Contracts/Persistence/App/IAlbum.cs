namespace QnSMusicStore.Contracts.Persistence.App
{
	public interface IAlbum : IIdentifiable, ICopyable<IAlbum>
    {
        int ArtistId { get; set; }
        string Title { get; set; }
    }
}
