using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_fee
    /// </summary>
    [Table("order_fee")]
    [DataContract]
    public partial class OrderFee
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderFee"/>的构造函数
        /// </summary>
        public OrderFee()
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
        /// 订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 1)]
        public long OrderId { get; set; } = (long)0;      	
        /// <summary>
        /// 订单项Id
        /// </summary>
        [Column("order_item_id")]
        [DataMember(Order = 2)]
        public long OrderItemId { get; set; } = (long)0;      	
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column("order_sn")]
        [DataMember(Order = 3)]
        [StringLength(128)]
        public string OrderSn { get; set; } = string.Empty;      	
        /// <summary>
        /// 订单金额调整类型id
        /// </summary>
        [Column("fee_type_id")]
        [DataMember(Order = 4)]
        public int FeeTypeId { get; set; } = 0;      	
        /// <summary>
        /// 订单金额调整类型名
        /// </summary>
        [Column("fee_type_name")]
        [DataMember(Order = 5)]
        [StringLength(100)]
        public string FeeTypeName { get; set; } = string.Empty;      	
        /// <summary>
        /// 调整的金额,-表示减免的金额
        /// </summary>
        [Column("amount")]
        [DataMember(Order = 6)]
        public decimal Amount { get; set; } = 0.00m;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 7)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 8)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 9)]
        public long CreatedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 修改人Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 10)]
        public long UpdatedBy { get; set; } = (long)0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderFee"></param>        
        public virtual void CopyTo(OrderFee orderFee)
        {
            orderFee.Id = Id;
            orderFee.OrderId = OrderId;
            orderFee.OrderItemId = OrderItemId;
            orderFee.OrderSn = OrderSn;
            orderFee.FeeTypeId = FeeTypeId;
            orderFee.FeeTypeName = FeeTypeName;
            orderFee.Amount = Amount;
            orderFee.CreatedOn = CreatedOn;
            orderFee.UpdatedOn = UpdatedOn;
            orderFee.CreatedBy = CreatedBy;
            orderFee.UpdatedBy = UpdatedBy;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderFee Clone()
        {
            var obj = new OrderFee();
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
            var sb = new System.Text.StringBuilder("OrderFee{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", OrderItemId='");
            sb.Append(OrderItemId).AppendLine("'");
            sb.Append(", OrderSn='");
            sb.Append(OrderSn).AppendLine("'");
            sb.Append(", FeeTypeId='");
            sb.Append(FeeTypeId).AppendLine("'");
            sb.Append(", FeeTypeName='");
            sb.Append(FeeTypeName).AppendLine("'");
            sb.Append(", Amount='");
            sb.Append(Amount).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}