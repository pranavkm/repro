using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_package
    /// </summary>
    [Table("order_package")]
    [DataContract]
    public partial class OrderPackage
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderPackage"/>的构造函数
        /// </summary>
        public OrderPackage()
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
        /// 订单明细项Id
        /// </summary>
        [Column("order_item_id")]
        [DataMember(Order = 1)]
        public long OrderItemId { get; set; } = 0;      	
        /// <summary>
        /// 包裹Id
        /// </summary>
        [Column("package_id")]
        [DataMember(Order = 2)]
        public long PackageId { get; set; } = 0;      	
        /// <summary>
        /// 订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 3)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 数量
        /// </summary>
        [Column("quantity")]
        [DataMember(Order = 4)]
        public decimal Quantity { get; set; } = 0.0m;      	
        /// <summary>
        /// 商品金额
        /// </summary>
        [Column("amount")]
        [DataMember(Order = 5)]
        public decimal Amount { get; set; } = 0.0m;      	
        /// <summary>
        /// 货币单位,如:USD,CNY
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 6)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// skuid
        /// </summary>
        [Column("sku_id")]
        [DataMember(Order = 7)]
        public long SkuId { get; set; } = 0;      	
        /// <summary>
        /// 商品id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 8)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column("order_sn")]
        [DataMember(Order = 9)]
        [StringLength(128)]
        public string OrderSn { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderPackage"></param>        
        public virtual void CopyTo(OrderPackage orderPackage)
        {
            orderPackage.Id = Id;
            orderPackage.OrderItemId = OrderItemId;
            orderPackage.PackageId = PackageId;
            orderPackage.OrderId = OrderId;
            orderPackage.Quantity = Quantity;
            orderPackage.Amount = Amount;
            orderPackage.Currency = Currency;
            orderPackage.SkuId = SkuId;
            orderPackage.ItemId = ItemId;
            orderPackage.OrderSn = OrderSn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderPackage Clone()
        {
            var obj = new OrderPackage();
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
            var sb = new System.Text.StringBuilder("OrderPackage{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderItemId='");
            sb.Append(OrderItemId).AppendLine("'");
            sb.Append(", PackageId='");
            sb.Append(PackageId).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", Quantity='");
            sb.Append(Quantity).AppendLine("'");
            sb.Append(", Amount='");
            sb.Append(Amount).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", SkuId='");
            sb.Append(SkuId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
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