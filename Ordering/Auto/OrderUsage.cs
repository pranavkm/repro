using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_usage
    /// </summary>
    [Table("order_usage")]
    [DataContract]
    public partial class OrderUsage
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderUsage"/>的构造函数
        /// </summary>
        public OrderUsage()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 订单id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 1)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 订单明细id
        /// </summary>
        [Column("order_item_id")]
        [DataMember(Order = 2)]
        public long OrderItemId { get; set; } = 0;      	
        /// <summary>
        /// 商品/服务skuid
        /// </summary>
        [Column("sku_id")]
        [DataMember(Order = 3)]
        public long SkuId { get; set; } = 0;      	
        /// <summary>
        /// 商品/服务id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 4)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 此次使用/消费数量
        /// </summary>
        [Column("quantity")]
        [DataMember(Order = 5)]
        public decimal Quantity { get; set; } = 0.000000m;      	
        /// <summary>
        /// 使用/消费总数量
        /// </summary>
        [Column("total")]
        [DataMember(Order = 6)]
        public decimal Total { get; set; } = 0.000000m;      	
        /// <summary>
        /// 使用/消费时间
        /// </summary>
        [Column("usage_time")]
        [DataMember(Order = 7)]
        public DateTimeOffset UsageTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 消费用户id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 8)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户id
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
        /// 服务/商品序列码
        /// </summary>
        [Column("order_code")]
        [DataMember(Order = 11)]
        [StringLength(128)]
        public string OrderCode { get; set; } = string.Empty;      	
        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        [DataMember(Order = 12)]
        [StringLength(2000)]
        public string Remark { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderUsage"></param>        
        public virtual void CopyTo(OrderUsage orderUsage)
        {
            orderUsage.Id = Id;
            orderUsage.OrderId = OrderId;
            orderUsage.OrderItemId = OrderItemId;
            orderUsage.SkuId = SkuId;
            orderUsage.ItemId = ItemId;
            orderUsage.Quantity = Quantity;
            orderUsage.Total = Total;
            orderUsage.UsageTime = UsageTime;
            orderUsage.UserId = UserId;
            orderUsage.CreatedBy = CreatedBy;
            orderUsage.CreatedOn = CreatedOn;
            orderUsage.OrderCode = OrderCode;
            orderUsage.Remark = Remark;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderUsage Clone()
        {
            var obj = new OrderUsage();
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
            var sb = new System.Text.StringBuilder("OrderUsage{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", OrderItemId='");
            sb.Append(OrderItemId).AppendLine("'");
            sb.Append(", SkuId='");
            sb.Append(SkuId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", Quantity='");
            sb.Append(Quantity).AppendLine("'");
            sb.Append(", Total='");
            sb.Append(Total).AppendLine("'");
            sb.Append(", UsageTime='");
            sb.Append(UsageTime).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", OrderCode='");
            sb.Append(OrderCode).AppendLine("'");
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