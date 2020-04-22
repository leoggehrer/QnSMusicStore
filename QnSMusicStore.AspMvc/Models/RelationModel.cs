//@QnSCodeCopy
//MdStart
using System.Collections.Generic;
using System.Linq;
using CommonBase.Extensions;

namespace QnSMusicStore.AspMvc.Models
{
    public abstract partial class RelationModel<TMaster, TMasterModel, TDetail, TDetailModel> : IdentityModel
        where TMaster : Contracts.IIdentifiable
        where TDetail : Contracts.IIdentifiable
        where TMasterModel : IdentityModel, Contracts.ICopyable<TMaster>, TMaster, new()
        where TDetailModel : IdentityModel, Contracts.ICopyable<TDetail>, TDetail, new()
    {
        public virtual TMasterModel MasterModel { get; } = new TMasterModel();
        public virtual TMaster Master => MasterModel;

        public virtual List<TDetailModel> DetailEntities { get; } = new List<TDetailModel>();
        public virtual IEnumerable<TDetail> Details => DetailEntities as IEnumerable<TDetail>;

        public override int Id { get => MasterModel.Id; set => MasterModel.Id = value; }
        public override byte[] Timestamp { get => MasterModel.Timestamp; set => MasterModel.Timestamp = value; }

        public virtual void ClearDetails()
        {
            DetailEntities.Clear();
        }
        public virtual TDetail CreateDetail()
        {
            return new TDetailModel();
        }
        public virtual void AddDetail(TDetail detail)
        {
            detail.CheckArgument(nameof(detail));

            var newDetail = new TDetailModel();

            newDetail.CopyProperties(detail);
            DetailEntities.Add(newDetail);
        }
        public virtual void RemoveDetail(TDetail detail)
        {
            detail.CheckArgument(nameof(detail));

            var removeDetail = DetailEntities.FirstOrDefault(i => i.Id == detail.Id);

            if (removeDetail != null)
            {
                DetailEntities.Remove(removeDetail);
            }
        }
    }
}
//MdEnd