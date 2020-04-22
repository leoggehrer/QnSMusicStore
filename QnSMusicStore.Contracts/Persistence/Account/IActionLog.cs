//@QnSCodeCopy
//MdStart
using System;

namespace QnSMusicStore.Contracts.Persistence.Account
{
    public partial interface IActionLog : IIdentifiable, ICopyable<IActionLog>
    {
        int IdentityId { get; set; }
        DateTime Time { get; set; }
        string Subject { get; set; }
        string Action { get; set; }
        string Info { get; set; }
    }
}
//MdEnd
