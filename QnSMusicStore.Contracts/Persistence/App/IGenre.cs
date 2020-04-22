namespace QnSMusicStore.Contracts.Persistence.App
{
    public interface IGenre : IIdentifiable, ICopyable<IGenre>
    {
        string Name { get; set; }
    }
}
