//@QnSCodeCopy
//MdStart

namespace QnSMusicStore.Contracts
{
    public partial interface IOneToOne<TFirst, TSecond> : IIdentifiable
        where TFirst : IIdentifiable
        where TSecond : IIdentifiable
    {
        TFirst FirstItem { get; }
        TSecond SecondItem { get; }
    }
}
//MdEnd
