//@QnSCodeCopy
//MdStart

namespace QnSMusicStore.Transfer
{
    public abstract partial class IdentityModel : TransferModel, Contracts.IIdentifiable
    {
        public virtual int Id { get; set; }
        public virtual byte[] RowVersion { get; set; }
	}
}
//MdEnd
