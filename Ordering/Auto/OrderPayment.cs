using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_payment
    /// </summary>
    [Table("order_payment")]
    [DataContract]
    public partial class OrderPayment
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderPayment"/>的构造函数
        /// </summary>
        public OrderPayment()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 自增Id
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
        /// 支付Id
        /// </summary>
        [Column("payment_id")]
        [DataMember(Order = 2)]
        public long PaymentId { get; set; } = 0;      	
        /// <summary>
        /// 支付金额
        /// </summary>
        [Column("payment_amount")]
        [DataMember(Order = 3)]
        public decimal PaymentAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 货币单位，如：CNY,USD
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 4)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// 支付状态：0=准备支付;1=完成支付;2=支付失败;
        /// </summary>
        [Column("payment_state")]
        [DataMember(Order = 5)]
        public int PaymentState { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderPayment"></param>        
        public virtual void CopyTo(OrderPayment orderPayment)
        {
            orderPayment.Id = Id;
            orderPayment.OrderId = OrderId;
            orderPayment.PaymentId = PaymentId;
            orderPayment.PaymentAmount = PaymentAmount;
            orderPayment.Currency = Currency;
            orderPayment.PaymentState = PaymentState;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderPayment Clone()
        {
            var obj = new OrderPayment();
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
            var sb = new System.Text.StringBuilder("OrderPayment{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", PaymentId='");
            sb.Append(PaymentId).AppendLine("'");
            sb.Append(", PaymentAmount='");
            sb.Append(PaymentAmount).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", PaymentState='");
            sb.Append(PaymentState).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}