using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_return_payment
    /// </summary>
    [Table("order_return_payment")]
    [DataContract]
    public partial class OrderReturnPayment
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderReturnPayment"/>的构造函数
        /// </summary>
        public OrderReturnPayment()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 退款Id
        /// </summary>
        [Key]
        [Column("return_item_id")]
        [DataMember(Order = 0)]
        public long ReturnItemId { get; set; } = 0;      	
        /// <summary>
        /// 支付Id
        /// </summary>
        [Key]
        [Column("payment_id")]
        [DataMember(Order = 1)]
        public long PaymentId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderReturnPayment"></param>        
        public virtual void CopyTo(OrderReturnPayment orderReturnPayment)
        {
            orderReturnPayment.ReturnItemId = ReturnItemId;
            orderReturnPayment.PaymentId = PaymentId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderReturnPayment Clone()
        {
            var obj = new OrderReturnPayment();
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
            var sb = new System.Text.StringBuilder("OrderReturnPayment{");
            sb.Append("ReturnItemId='");
            sb.Append(ReturnItemId).AppendLine("'");
            sb.Append(", PaymentId='");
            sb.Append(PaymentId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}