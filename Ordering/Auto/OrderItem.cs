using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_item
    /// </summary>
    [Table("order_item")]
    [DataContract]
    public partial class OrderItem
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderItem"/>的构造函数
        /// </summary>
        public OrderItem()
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
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 3)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 商品Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 4)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// SkuId
        /// </summary>
        [Column("sku_id")]
        [DataMember(Order = 5)]
        public long SkuId { get; set; } = 0;      	
        /// <summary>
        /// 单价
        /// </summary>
        [Column("price")]
        [DataMember(Order = 6)]
        public decimal Price { get; set; } = 0.0m;      	
        /// <summary>
        /// 数量
        /// </summary>
        [Column("quantity")]
        [DataMember(Order = 7)]
        public decimal Quantity { get; set; } = 0.000000m;      	
        /// <summary>
        /// 商品金额=unit_price*quantity
        /// </summary>
        [Column("net_amount")]
        [DataMember(Order = 8)]
        public decimal NetAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 订购金额=商品金额+商品税金额-优惠金额
        /// </summary>
        [Column("total_amount")]
        [DataMember(Order = 9)]
        public decimal TotalAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 优惠金额
        /// </summary>
        [Column("discount_amount")]
        [DataMember(Order = 10)]
        public decimal DiscountAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 商品税金额
        /// </summary>
        [Column("tax_amount")]
        [DataMember(Order = 11)]
        public decimal TaxAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 退货数量
        /// </summary>
        [Column("return_quantity")]
        [DataMember(Order = 12)]
        public decimal ReturnQuantity { get; set; } = 0.000000m;      	
        /// <summary>
        /// 退款金额
        /// </summary>
        [Column("refund_amount")]
        [DataMember(Order = 13)]
        public decimal RefundAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 货币单位,如:USD,CNY
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 14)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// 业务类型:0=未明确;1=实物;2=服务;4=虚拟;8=押金;16:担保
        /// </summary>
        [Column("business_type")]
        [DataMember(Order = 15)]
        public int BusinessType { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 16)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 17)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 18)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新人Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 19)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 退货完成时间
        /// </summary>
        [Column("return_time")]
        [DataMember(Order = 20)]
        public DateTimeOffset? ReturnTime { get; set; } = null;      	
        /// <summary>
        /// 退款完成时间
        /// </summary>
        [Column("refund_time")]
        [DataMember(Order = 21)]
        public DateTimeOffset? RefundTime { get; set; } = null;      	
        /// <summary>
        /// 商品名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 22)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 品牌名
        /// </summary>
        [Column("brand_name")]
        [DataMember(Order = 23)]
        [StringLength(200)]
        public string BrandName { get; set; } = string.Empty;      	
        /// <summary>
        /// sku编号
        /// </summary>
        [Column("sku_sn")]
        [DataMember(Order = 24)]
        [StringLength(128)]
        public string SkuSn { get; set; } = null;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 25)]
        [StringLength(1000)]
        public string Description { get; set; } = null;      	
        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        [DataMember(Order = 26)]
        [StringLength(500)]
        public string Remark { get; set; } = null;      	
        /// <summary>
        /// 使用/消费数量
        /// </summary>
        [Column("usage_quantity")]
        [DataMember(Order = 27)]
        public decimal UsageQuantity { get; set; } = 0.000000m;      	
        /// <summary>
        /// 包括的服务/商品总数量,等于quantity乘sku的unit_quanttity
        /// </summary>
        [Column("total_quantity")]
        [DataMember(Order = 28)]
        public decimal TotalQuantity { get; set; } = 0.0m;      	
        /// <summary>
        /// 成本价/进货价
        /// </summary>
        [Column("cost_price")]
        [DataMember(Order = 29)]
        public decimal? CostPrice { get; set; } = null;      	
        /// <summary>
        /// sku销售属性值(json格式)
        /// </summary>
        [Column("sku_values")]
        [DataMember(Order = 30)]
        [StringLength(2000)]
        public string SkuValues { get; set; } = null;      	
        /// <summary>
        /// 佣金比例
        /// </summary>
        [Column("commission_rate")]
        [DataMember(Order = 31)]
        public decimal? CommissionRate { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderItem"></param>        
        public virtual void CopyTo(OrderItem orderItem)
        {
            orderItem.Id = Id;
            orderItem.OrderId = OrderId;
            orderItem.OrderSn = OrderSn;
            orderItem.UserId = UserId;
            orderItem.ItemId = ItemId;
            orderItem.SkuId = SkuId;
            orderItem.Price = Price;
            orderItem.Quantity = Quantity;
            orderItem.NetAmount = NetAmount;
            orderItem.TotalAmount = TotalAmount;
            orderItem.DiscountAmount = DiscountAmount;
            orderItem.TaxAmount = TaxAmount;
            orderItem.ReturnQuantity = ReturnQuantity;
            orderItem.RefundAmount = RefundAmount;
            orderItem.Currency = Currency;
            orderItem.BusinessType = BusinessType;
            orderItem.CreatedOn = CreatedOn;
            orderItem.UpdatedOn = UpdatedOn;
            orderItem.CreatedBy = CreatedBy;
            orderItem.UpdatedBy = UpdatedBy;
            orderItem.ReturnTime = ReturnTime;
            orderItem.RefundTime = RefundTime;
            orderItem.Name = Name;
            orderItem.BrandName = BrandName;
            orderItem.SkuSn = SkuSn;
            orderItem.Description = Description;
            orderItem.Remark = Remark;
            orderItem.UsageQuantity = UsageQuantity;
            orderItem.TotalQuantity = TotalQuantity;
            orderItem.CostPrice = CostPrice;
            orderItem.SkuValues = SkuValues;
            orderItem.CommissionRate = CommissionRate;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderItem Clone()
        {
            var obj = new OrderItem();
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
            var sb = new System.Text.StringBuilder("OrderItem{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", OrderSn='");
            sb.Append(OrderSn).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", SkuId='");
            sb.Append(SkuId).AppendLine("'");
            sb.Append(", Price='");
            sb.Append(Price).AppendLine("'");
            sb.Append(", Quantity='");
            sb.Append(Quantity).AppendLine("'");
            sb.Append(", NetAmount='");
            sb.Append(NetAmount).AppendLine("'");
            sb.Append(", TotalAmount='");
            sb.Append(TotalAmount).AppendLine("'");
            sb.Append(", DiscountAmount='");
            sb.Append(DiscountAmount).AppendLine("'");
            sb.Append(", TaxAmount='");
            sb.Append(TaxAmount).AppendLine("'");
            sb.Append(", ReturnQuantity='");
            sb.Append(ReturnQuantity).AppendLine("'");
            sb.Append(", RefundAmount='");
            sb.Append(RefundAmount).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", BusinessType='");
            sb.Append(BusinessType).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", ReturnTime='");
            sb.Append(ReturnTime).AppendLine("'");
            sb.Append(", RefundTime='");
            sb.Append(RefundTime).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", BrandName='");
            sb.Append(BrandName).AppendLine("'");
            sb.Append(", SkuSn='");
            sb.Append(SkuSn).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", Remark='");
            sb.Append(Remark).AppendLine("'");
            sb.Append(", UsageQuantity='");
            sb.Append(UsageQuantity).AppendLine("'");
            sb.Append(", TotalQuantity='");
            sb.Append(TotalQuantity).AppendLine("'");
            sb.Append(", CostPrice='");
            sb.Append(CostPrice).AppendLine("'");
            sb.Append(", SkuValues='");
            sb.Append(SkuValues).AppendLine("'");
            sb.Append(", CommissionRate='");
            sb.Append(CommissionRate).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}