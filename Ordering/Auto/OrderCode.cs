using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_code
    /// </summary>
    [Table("order_code")]
    [DataContract]
    public partial class OrderCode
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderCode"/>的构造函数
        /// </summary>
        public OrderCode()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 序列码
        /// </summary>
        [Key]
        [Column("code")]
        [DataMember(Order = 0)]
        [StringLength(128)]
        public string Code { get; set; } = string.Empty;      	
        /// <summary>
        /// 有效开始时间
        /// </summary>
        [Column("begin_time")]
        [DataMember(Order = 1)]
        public DateTimeOffset BeginTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 过期时间
        /// </summary>
        [Column("expire_time")]
        [DataMember(Order = 2)]
        public DateTimeOffset ExpireTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 所属用户id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 4)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态,1=有效
        /// </summary>
        [Column("state")]
        [DataMember(Order = 5)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 是否已经使用
        /// </summary>
        [Column("is_used")]
        [DataMember(Order = 6)]
        public bool IsUsed { get; set; } = false;      	
        /// <summary>
        /// 使用用户id
        /// </summary>
        [Column("used_by")]
        [DataMember(Order = 7)]
        public long UsedBy { get; set; } = 0;      	
        /// <summary>
        /// 使用时间
        /// </summary>
        [Column("used_time")]
        [DataMember(Order = 8)]
        public DateTimeOffset? UsedTime { get; set; } = null;      	
        /// <summary>
        /// 订单id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 9)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 订单明细id
        /// </summary>
        [Column("order_item_id")]
        [DataMember(Order = 10)]
        public long OrderItemId { get; set; } = 0;      	
        /// <summary>
        /// 所包含的服务/商品数量
        /// </summary>
        [Column("quantity")]
        [DataMember(Order = 11)]
        public decimal Quantity { get; set; } = 0.0m;      	
        /// <summary>
        /// 消费者/权益人id
        /// </summary>
        [Column("consumer_id")]
        [DataMember(Order = 12)]
        public long ConsumerId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderCode"></param>        
        public virtual void CopyTo(OrderCode orderCode)
        {
            orderCode.Code = Code;
            orderCode.BeginTime = BeginTime;
            orderCode.ExpireTime = ExpireTime;
            orderCode.CreatedOn = CreatedOn;
            orderCode.UserId = UserId;
            orderCode.State = State;
            orderCode.IsUsed = IsUsed;
            orderCode.UsedBy = UsedBy;
            orderCode.UsedTime = UsedTime;
            orderCode.OrderId = OrderId;
            orderCode.OrderItemId = OrderItemId;
            orderCode.Quantity = Quantity;
            orderCode.ConsumerId = ConsumerId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderCode Clone()
        {
            var obj = new OrderCode();
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
            var sb = new System.Text.StringBuilder("OrderCode{");
            sb.Append("Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", BeginTime='");
            sb.Append(BeginTime).AppendLine("'");
            sb.Append(", ExpireTime='");
            sb.Append(ExpireTime).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", IsUsed='");
            sb.Append(IsUsed).AppendLine("'");
            sb.Append(", UsedBy='");
            sb.Append(UsedBy).AppendLine("'");
            sb.Append(", UsedTime='");
            sb.Append(UsedTime).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", OrderItemId='");
            sb.Append(OrderItemId).AppendLine("'");
            sb.Append(", Quantity='");
            sb.Append(Quantity).AppendLine("'");
            sb.Append(", ConsumerId='");
            sb.Append(ConsumerId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}