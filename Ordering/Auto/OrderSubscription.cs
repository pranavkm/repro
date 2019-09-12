using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_subscription
    /// </summary>
    [Table("order_subscription")]
    [DataContract]
    public partial class OrderSubscription
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderSubscription"/>的构造函数
        /// </summary>
        public OrderSubscription()
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
        /// 关联的订单id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 1)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 关联的订单明细id
        /// </summary>
        [Column("order_item_id")]
        [DataMember(Order = 2)]
        public long OrderItemId { get; set; } = 0;      	
        /// <summary>
        /// 服务/商品skuid
        /// </summary>
        [Column("sku_id")]
        [DataMember(Order = 3)]
        public long SkuId { get; set; } = 0;      	
        /// <summary>
        /// 服务/商品id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 4)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 开始时间
        /// </summary>
        [Column("begin_time")]
        [DataMember(Order = 5)]
        public DateTimeOffset BeginTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 结束时间
        /// </summary>
        [Column("end_time")]
        [DataMember(Order = 6)]
        public DateTimeOffset EndTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 绑定用户id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 7)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 下单用户id
        /// </summary>
        [Column("buyer_id")]
        [DataMember(Order = 8)]
        public long BuyerId { get; set; } = 0;      	
        /// <summary>
        /// 服务名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 9)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 11)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 订阅者Id
        /// </summary>
        [Column("subscriber_id")]
        [DataMember(Order = 12)]
        [StringLength(100)]
        public string SubscriberId { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderSubscription"></param>        
        public virtual void CopyTo(OrderSubscription orderSubscription)
        {
            orderSubscription.Id = Id;
            orderSubscription.OrderId = OrderId;
            orderSubscription.OrderItemId = OrderItemId;
            orderSubscription.SkuId = SkuId;
            orderSubscription.ItemId = ItemId;
            orderSubscription.BeginTime = BeginTime;
            orderSubscription.EndTime = EndTime;
            orderSubscription.UserId = UserId;
            orderSubscription.BuyerId = BuyerId;
            orderSubscription.Name = Name;
            orderSubscription.CreatedOn = CreatedOn;
            orderSubscription.UpdatedOn = UpdatedOn;
            orderSubscription.SubscriberId = SubscriberId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderSubscription Clone()
        {
            var obj = new OrderSubscription();
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
            var sb = new System.Text.StringBuilder("OrderSubscription{");
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
            sb.Append(", BeginTime='");
            sb.Append(BeginTime).AppendLine("'");
            sb.Append(", EndTime='");
            sb.Append(EndTime).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", BuyerId='");
            sb.Append(BuyerId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", SubscriberId='");
            sb.Append(SubscriberId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}