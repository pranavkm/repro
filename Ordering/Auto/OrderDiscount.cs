using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_discount
    /// </summary>
    [Table("order_discount")]
    [DataContract]
    public partial class OrderDiscount
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderDiscount"/>的构造函数
        /// </summary>
        public OrderDiscount()
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
        /// 订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 1)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column("order_sn")]
        [DataMember(Order = 2)]
        [StringLength(128)]
        public string OrderSn { get; set; } = string.Empty;      	
        /// <summary>
        /// 订单项Id
        /// </summary>
        [Column("order_item_id")]
        [DataMember(Order = 3)]
        public long OrderItemId { get; set; } = 0;      	
        /// <summary>
        /// 优惠策略Id
        /// </summary>
        [Column("discount_policy_id")]
        [DataMember(Order = 4)]
        public int DiscountPolicyId { get; set; } = 0;      	
        /// <summary>
        /// 优惠范围的适用范围Id，如有=DiscountRange.Id
        /// </summary>
        [Column("discount_range_id")]
        [DataMember(Order = 5)]
        public int DiscountRangeId { get; set; } = (int)0;      	
        /// <summary>
        /// 优惠券Id/码
        /// </summary>
        [Column("coupon_id")]
        [DataMember(Order = 6)]
        [StringLength(64)]
        public string CouponId { get; set; } = string.Empty;      	
        /// <summary>
        /// 优惠金额 正数，绝对现金值
        /// </summary>
        [Column("discount_amount")]
        [DataMember(Order = 7)]
        public decimal DiscountAmount { get; set; } = 0.00m;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderDiscount"></param>        
        public virtual void CopyTo(OrderDiscount orderDiscount)
        {
            orderDiscount.Id = Id;
            orderDiscount.OrderId = OrderId;
            orderDiscount.OrderSn = OrderSn;
            orderDiscount.OrderItemId = OrderItemId;
            orderDiscount.DiscountPolicyId = DiscountPolicyId;
            orderDiscount.DiscountRangeId = DiscountRangeId;
            orderDiscount.CouponId = CouponId;
            orderDiscount.DiscountAmount = DiscountAmount;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderDiscount Clone()
        {
            var obj = new OrderDiscount();
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
            var sb = new System.Text.StringBuilder("OrderDiscount{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", OrderSn='");
            sb.Append(OrderSn).AppendLine("'");
            sb.Append(", OrderItemId='");
            sb.Append(OrderItemId).AppendLine("'");
            sb.Append(", DiscountPolicyId='");
            sb.Append(DiscountPolicyId).AppendLine("'");
            sb.Append(", DiscountRangeId='");
            sb.Append(DiscountRangeId).AppendLine("'");
            sb.Append(", CouponId='");
            sb.Append(CouponId).AppendLine("'");
            sb.Append(", DiscountAmount='");
            sb.Append(DiscountAmount).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}