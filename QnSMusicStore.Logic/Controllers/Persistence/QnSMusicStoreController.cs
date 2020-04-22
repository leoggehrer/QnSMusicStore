//MdStart
using QnSMusicStore.Logic.DataContext;

namespace QnSMusicStore.Logic.Controllers.Persistence
{
    internal abstract partial class QnSMusicStoreController<I, E> : GenericController<I, E>
       where I : Contracts.IIdentifiable
       where E : Entities.IdentityObject, I, Contracts.ICopyable<I>, new()
    {
        internal IQnSMusicStoreContext QnSMusicStoreContext => (IQnSMusicStoreContext)Context;

        protected QnSMusicStoreController(IContext context)
            : base(context)
        {
        }
        protected QnSMusicStoreController(ControllerObject controller)
            : base(controller)
        {
        }
    }
}
//MdEnd
