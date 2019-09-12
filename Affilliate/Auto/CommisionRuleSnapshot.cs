using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of commision_rule_snapshot
    /// </summary>
    [Table("commision_rule_snapshot")]
    [DataContract]
    public partial class CommisionRuleSnapshot
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CommisionRuleSnapshot"/>的构造函数
        /// </summary>
        public CommisionRuleSnapshot()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 佣金规则Id
        /// </summary>
        [Column("rule_id")]
        [DataMember(Order = 1)]
        public int RuleId { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 基础比例
        /// </summary>
        [Column("base_rate")]
        [DataMember(Order = 3)]
        public decimal BaseRate { get; set; } = 0.0m;      	
        /// <summary>
        /// KOL占比/金额
        /// </summary>
        [Column("contributor_amount")]
        [DataMember(Order = 4)]
        public decimal ContributorAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 推广用户占比/金额
        /// </summary>
        [Column("affiliate_amount")]
        [DataMember(Order = 5)]
        public decimal AffiliateAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 1=cpm(每千个PV佣金),2=cpv(每个UV佣金),3=cpa(每注册佣金),4=cps(销售佣金比例)
        /// </summary>
        [Column("commision_type")]
        [DataMember(Order = 6)]
        public int CommisionType { get; set; } = 0;      	
        /// <summary>
        /// KOL用户Id
        /// </summary>
        [Column("contributor_id")]
        [DataMember(Order = 7)]
        public long ContributorId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 9)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 11)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 12)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 计费方式1=按百分比,2=按固定金额
        /// </summary>
        [Column("amount_type")]
        [DataMember(Order = 13)]
        public int AmountType { get; set; } = 0;      	
        /// <summary>
        /// 快照时间
        /// </summary>
        [Column("snapshot_time")]
        [DataMember(Order = 14)]
        public DateTimeOffset SnapshotTime { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="commisionRuleSnapshot"></param>        
        public virtual void CopyTo(CommisionRuleSnapshot commisionRuleSnapshot)
        {
            commisionRuleSnapshot.Id = Id;
            commisionRuleSnapshot.RuleId = RuleId;
            commisionRuleSnapshot.Name = Name;
            commisionRuleSnapshot.BaseRate = BaseRate;
            commisionRuleSnapshot.ContributorAmount = ContributorAmount;
            commisionRuleSnapshot.AffiliateAmount = AffiliateAmount;
            commisionRuleSnapshot.CommisionType = CommisionType;
            commisionRuleSnapshot.ContributorId = ContributorId;
            commisionRuleSnapshot.State = State;
            commisionRuleSnapshot.CreatedBy = CreatedBy;
            commisionRuleSnapshot.CreatedOn = CreatedOn;
            commisionRuleSnapshot.UpdatedBy = UpdatedBy;
            commisionRuleSnapshot.UpdatedOn = UpdatedOn;
            commisionRuleSnapshot.AmountType = AmountType;
            commisionRuleSnapshot.SnapshotTime = SnapshotTime;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CommisionRuleSnapshot Clone()
        {
            var obj = new CommisionRuleSnapshot();
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
            var sb = new System.Text.StringBuilder("CommisionRuleSnapshot{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", RuleId='");
            sb.Append(RuleId).AppendLine("'");
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
            sb.Append(", SnapshotTime='");
            sb.Append(SnapshotTime).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}