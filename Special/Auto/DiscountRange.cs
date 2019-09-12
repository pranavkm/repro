using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of discount_range
    /// </summary>
    [Table("discount_range")]
    [DataContract]
    public partial class DiscountRange
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.DiscountRange"/>的构造函数
        /// </summary>
        public DiscountRange()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 自增Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 优惠策略Id=DiscountPolicy.Id
        /// </summary>
        [Column("policy_id")]
        [DataMember(Order = 1)]
        public int PolicyId { get; set; } = 0;      	
        /// <summary>
        /// 优惠对象类型0=商品,1=商家,2=品类,3=品牌,4=活动
        /// </summary>
        [Column("object_type")]
        [DataMember(Order = 2)]
        public int ObjectType { get; set; } = (int)0;      	
        /// <summary>
        /// 包含的优惠对象Id集合,逗号分隔
        /// </summary>
        [Column("include_ids")]
        [DataMember(Order = 3)]
        public string IncludeIds { get; set; } = string.Empty;      	
        /// <summary>
        /// 排除的优惠对象Id集合,逗号分隔
        /// </summary>
        [Column("exclude_ids")]
        [DataMember(Order = 4)]
        public string ExcludeIds { get; set; } = string.Empty;      	
        /// <summary>
        /// 此数据状态:0=未知;1=有效;2=无效;3=作废;4=删除
        /// </summary>
        [Column("state")]
        [DataMember(Order = 5)]
        public int State { get; set; } = (int)0;      	
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 6)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 7)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新人Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 8)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="discountRange"></param>        
        public virtual void CopyTo(DiscountRange discountRange)
        {
            discountRange.Id = Id;
            discountRange.PolicyId = PolicyId;
            discountRange.ObjectType = ObjectType;
            discountRange.IncludeIds = IncludeIds;
            discountRange.ExcludeIds = ExcludeIds;
            discountRange.State = State;
            discountRange.CreatedBy = CreatedBy;
            discountRange.CreatedOn = CreatedOn;
            discountRange.UpdatedBy = UpdatedBy;
            discountRange.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual DiscountRange Clone()
        {
            var obj = new DiscountRange();
            CopyTo(obj);
            return obj;
        }
        #endregion
        
        #region 重载方法
        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder("DiscountRange{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", PolicyId='");
            sb.Append(PolicyId).AppendLine("'");
            sb.Append(", ObjectType='");
            sb.Append(ObjectType).AppendLine("'");
            sb.Append(", IncludeIds='");
            sb.Append(IncludeIds).AppendLine("'");
            sb.Append(", ExcludeIds='");
            sb.Append(ExcludeIds).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}