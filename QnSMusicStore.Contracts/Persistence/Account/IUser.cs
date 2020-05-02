//@QnSCodeCopy
//MdStart
using QnSMusicStore.Contracts.Modules.Common;

namespace QnSMusicStore.Contracts.Persistence.Account
{
    public partial interface IUser : IIdentifiable, ICopyable<IUser>
    {
        int IdentityId { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
    }
}
//MdEnd
