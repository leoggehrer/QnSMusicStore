//@QnSCodeCopy
//MdStart
using QnSMusicStore.Contracts;
using QnSMusicStore.Contracts.Client;

namespace QnSMusicStore.AspMvc
{
    public interface IFactoryWrapper
    {
        IAdapterAccess<I> Create<I>() where I : IIdentifiable;
        IAdapterAccess<I> Create<I>(string sessionToken) where I : IIdentifiable;
    }
}
//MdEnd
