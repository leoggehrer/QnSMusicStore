//@QnSCodeCopy
//MdStart
namespace QnSMusicStore.Contracts.Persistence.Account
{
    public partial interface IRole : IIdentifiable, ICopyable<IRole>
    {
        string Designation { get; set; }
        string Description { get; set; }
    }
}
//MdEnd
