namespace QnSMusicStore.Contracts.Persistence.App
{
    public interface IArtist : IIdentifiable, ICopyable<IArtist>
    {
        string Name { get; set; }
    }
}
