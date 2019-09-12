using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of commision
    /// </summary>
    [Table("commision")]
    [DataContract]
    public partial class Commision
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Commision"/>的构造函数
        /// </summary>
        public Commision()
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
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 佣金所属用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 1)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 相关订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 2)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 相关信息Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 3)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 4)]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;      	
        /// <summary>
        /// 佣金的计费模式,1=cps,2=cpc
        /// </summary>
        [Column("type")]
        [DataMember(Order = 5)]
        public int Type { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 结算状态
        /// </summary>
        [Column("settle_state")]
        [DataMember(Order = 7)]
        public int SettleState { get; set; } = 0;      	
        /// <summary>
        /// 结算时间
        /// </summary>
        [Column("settle_time")]
        [DataMember(Order = 8)]
        public DateTimeOffset? SettleTime { get; set; } = null;      	
        /// <summary>
        /// 佣金金额
        /// </summary>
        [Column("amount")]
        [DataMember(Order = 9)]
        public decimal Amount { get; set; } = 0.0m;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 11)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 规则Id
        /// </summary>
        [Column("rule_id")]
        [DataMember(Order = 12)]
        public int RuleId { get; set; } = 0;      	
        /// <summary>
        /// 规则快照Id
        /// </summary>
        [Column("rule_snapshot_id")]
        [DataMember(Order = 13)]
        public long RuleSnapshotId { get; set; } = 0;      	
        /// <summary>
        /// 佣金的来源类型,1=来源于内容,2=来源于分享
        /// </summary>
        [Column("source_type")]
        [DataMember(Order = 14)]
        public int SourceType { get; set; } = 0;      	
        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        [DataMember(Order = 15)]
        [StringLength(500)]
        public string Remark { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="commision"></param>        
        public virtual void CopyTo(Commision commision)
        {
            commision.Id = Id;
            commision.UserId = UserId;
            commision.OrderId = OrderId;
            commision.ItemId = ItemId;
            commision.Title = Title;
            commision.Type = Type;
            commision.CreatedOn = CreatedOn;
            commision.SettleState = SettleState;
            commision.SettleTime = SettleTime;
            commision.Amount = Amount;
            commision.UpdatedOn = UpdatedOn;
            commision.State = State;
            commision.RuleId = RuleId;
            commision.RuleSnapshotId = RuleSnapshotId;
            commision.SourceType = SourceType;
            commision.Remark = Remark;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Commision Clone()
        {
            var obj = new Commision();
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
            var sb = new System.Text.StringBuilder("Commision{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Type='");
            sb.Append(Type).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", SettleState='");
            sb.Append(SettleState).AppendLine("'");
            sb.Append(", SettleTime='");
            sb.Append(SettleTime).AppendLine("'");
            sb.Append(", Amount='");
            sb.Append(Amount).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", RuleId='");
            sb.Append(RuleId).AppendLine("'");
            sb.Append(", RuleSnapshotId='");
            sb.Append(RuleSnapshotId).AppendLine("'");
            sb.Append(", SourceType='");
            sb.Append(SourceType).AppendLine("'");
            sb.Append(", Remark='");
            sb.Append(Remark).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}