using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_return_item
    /// </summary>
    [Table("order_return_item")]
    [DataContract]
    public partial class OrderReturnItem
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderReturnItem"/>的构造函数
        /// </summary>
        public OrderReturnItem()
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
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 1)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 2)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 订单明细项Id
        /// </summary>
        [Column("order_item_id")]
        [DataMember(Order = 3)]
        public long OrderItemId { get; set; } = 0;      	
        /// <summary>
        /// 数量
        /// </summary>
        [Column("quantity")]
        [DataMember(Order = 4)]
        public decimal Quantity { get; set; } = 0.0m;      	
        /// <summary>
        /// 退款金额
        /// </summary>
        [Column("return_amount")]
        [DataMember(Order = 5)]
        public decimal ReturnAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 退款状态
        /// </summary>
        [Column("return_state")]
        [DataMember(Order = 6)]
        public int ReturnState { get; set; } = 0;      	
        /// <summary>
        /// 支付状态
        /// </summary>
        [Column("payment_state")]
        [DataMember(Order = 7)]
        public int PaymentState { get; set; } = 0;      	
        /// <summary>
        /// 退款原因
        /// </summary>
        [Column("return_reason")]
        [DataMember(Order = 8)]
        public int ReturnReason { get; set; } = 0;      	
        /// <summary>
        /// 用户退款说明
        /// </summary>
        [Column("user_comment")]
        [DataMember(Order = 9)]
        [StringLength(2000)]
        public string UserComment { get; set; } = string.Empty;      	
        /// <summary>
        /// 客服退款说明
        /// </summary>
        [Column("staff_note")]
        [DataMember(Order = 10)]
        [StringLength(2000)]
        public string StaffNote { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 11)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新人Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 12)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 13)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 14)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column("order_sn")]
        [DataMember(Order = 15)]
        [StringLength(128)]
        public string OrderSn { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderReturnItem"></param>        
        public virtual void CopyTo(OrderReturnItem orderReturnItem)
        {
            orderReturnItem.Id = Id;
            orderReturnItem.UserId = UserId;
            orderReturnItem.OrderId = OrderId;
            orderReturnItem.OrderItemId = OrderItemId;
            orderReturnItem.Quantity = Quantity;
            orderReturnItem.ReturnAmount = ReturnAmount;
            orderReturnItem.ReturnState = ReturnState;
            orderReturnItem.PaymentState = PaymentState;
            orderReturnItem.ReturnReason = ReturnReason;
            orderReturnItem.UserComment = UserComment;
            orderReturnItem.StaffNote = StaffNote;
            orderReturnItem.CreatedBy = CreatedBy;
            orderReturnItem.UpdatedBy = UpdatedBy;
            orderReturnItem.CreatedOn = CreatedOn;
            orderReturnItem.UpdatedOn = UpdatedOn;
            orderReturnItem.OrderSn = OrderSn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderReturnItem Clone()
        {
            var obj = new OrderReturnItem();
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
            var sb = new System.Text.StringBuilder("OrderReturnItem{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", OrderItemId='");
            sb.Append(OrderItemId).AppendLine("'");
            sb.Append(", Quantity='");
            sb.Append(Quantity).AppendLine("'");
            sb.Append(", ReturnAmount='");
            sb.Append(ReturnAmount).AppendLine("'");
            sb.Append(", ReturnState='");
            sb.Append(ReturnState).AppendLine("'");
            sb.Append(", PaymentState='");
            sb.Append(PaymentState).AppendLine("'");
            sb.Append(", ReturnReason='");
            sb.Append(ReturnReason).AppendLine("'");
            sb.Append(", UserComment='");
            sb.Append(UserComment).AppendLine("'");
            sb.Append(", StaffNote='");
            sb.Append(StaffNote).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", OrderSn='");
            sb.Append(OrderSn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}