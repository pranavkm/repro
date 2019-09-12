using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of commision_rule
    /// </summary>
    [Table("commision_rule")]
    [DataContract]
    public partial class CommisionRule
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CommisionRule"/>的构造函数
        /// </summary>
        public CommisionRule()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 基础比例
        /// </summary>
        [Column("base_rate")]
        [DataMember(Order = 2)]
        public decimal BaseRate { get; set; } = 0.0m;      	
        /// <summary>
        /// KOL占比/金额
        /// </summary>
        [Column("contributor_amount")]
        [DataMember(Order = 3)]
        public decimal ContributorAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 推广用户占比/金额
        /// </summary>
        [Column("affiliate_amount")]
        [DataMember(Order = 4)]
        public decimal AffiliateAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 1=cpm(每千个PV佣金),2=cpv(每个UV佣金),3=cpa(每注册佣金),4=cps(销售佣金比例)
        /// </summary>
        [Column("commision_type")]
        [DataMember(Order = 5)]
        public int CommisionType { get; set; } = 0;      	
        /// <summary>
        /// KOL用户Id
        /// </summary>
        [Column("contributor_id")]
        [DataMember(Order = 6)]
        public long ContributorId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 7)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 8)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 10)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 11)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 计费方式1=按百分比,2=按固定金额
        /// </summary>
        [Column("amount_type")]
        [DataMember(Order = 12)]
        public int AmountType { get; set; } = 0;      	
        /// <summary>
        /// 规则快照Id
        /// </summary>
        [Column("snapshot_id")]
        [DataMember(Order = 13)]
        public long SnapshotId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="commisionRule"></param>        
        public virtual void CopyTo(CommisionRule commisionRule)
        {
            commisionRule.Id = Id;
            commisionRule.Name = Name;
            commisionRule.BaseRate = BaseRate;
            commisionRule.ContributorAmount = ContributorAmount;
            commisionRule.AffiliateAmount = AffiliateAmount;
            commisionRule.CommisionType = CommisionType;
            commisionRule.ContributorId = ContributorId;
            commisionRule.State = State;
            commisionRule.CreatedBy = CreatedBy;
            commisionRule.CreatedOn = CreatedOn;
            commisionRule.UpdatedBy = UpdatedBy;
            commisionRule.UpdatedOn = UpdatedOn;
            commisionRule.AmountType = AmountType;
            commisionRule.SnapshotId = SnapshotId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CommisionRule Clone()
        {
            var obj = new CommisionRule();
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
            var sb = new System.Text.StringBuilder("CommisionRule{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", BaseRate='");
            sb.Append(BaseRate).AppendLine("'");
            sb.Append(", ContributorAmount='");
            sb.Append(ContributorAmount).AppendLine("'");
            sb.Append(", AffiliateAmount='");
            sb.Append(AffiliateAmount).AppendLine("'");
            sb.Append(", CommisionType='");
            sb.Append(CommisionType).AppendLine("'");
            sb.Append(", ContributorId='");
            sb.Append(ContributorId).AppendLine("'");
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
            sb.Append(", AmountType='");
            sb.Append(AmountType).AppendLine("'");
            sb.Append(", SnapshotId='");
            sb.Append(SnapshotId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}