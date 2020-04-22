namespace QnSMusicStore.Contracts.Persistence.App
{
    public interface ITrack : IIdentifiable, ICopyable<ITrack>
    {
        int AlbumId { get; set; }
        int GenreId { get; set; }
        string Title { get; set; }
		string Composer { get; set; }
        long Milliseconds { get; set; }
        long Bytes { get; set; }
        double UnitPrice { get; set; }
    }
}
