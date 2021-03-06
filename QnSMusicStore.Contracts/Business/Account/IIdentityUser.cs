//@QnSCodeCopy
//MdStart
using QnSMusicStore.Contracts.Persistence.Account;

namespace QnSMusicStore.Contracts.Business.Account
{
    public partial interface IIdentityUser : IOneToOne<IIdentity, IUser>, ICopyable<IIdentityUser>
    {
    }
}
//MdEnd
