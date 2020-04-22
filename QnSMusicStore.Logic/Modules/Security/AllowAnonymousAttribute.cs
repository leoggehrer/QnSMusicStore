//@QnSCodeCopy
//MdStart
using System;

namespace QnSMusicStore.Logic.Modules.Security
{
    [AttributeUsage(AttributeTargets.Method)]
    internal partial class AllowAnonymousAttribute : AuthorizeAttribute
    {
        public AllowAnonymousAttribute()
            : base(false)
        {

        }
    }
}
//MdEnd
