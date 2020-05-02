//@QnSCodeCopy
//MdStart
using QnSMusicStore.Contracts.Persistence.Account;

namespace QnSMusicStore.Contracts.Business.Account
{
    public partial interface IAppAccess : IOneToMany<IIdentity, IRole>, ICopyable<IAppAccess>
    {

    }
}
//MdEnd
