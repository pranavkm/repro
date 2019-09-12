using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_fee_type
    /// </summary>
    [Table("order_fee_type")]
    [DataContract]
    public partial class OrderFeeType
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderFeeType"/>的构造函数
        /// </summary>
        public OrderFeeType()
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
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 订单金额调整项名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; } = null;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 2)]
        public int? State { get; set; } = null;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 3)]
        [StringLength(500)]
        public string Description { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderFeeType"></param>        
        public virtual void CopyTo(OrderFeeType orderFeeType)
        {
            orderFeeType.Id = Id;
            orderFeeType.Name = Name;
            orderFeeType.State = State;
            orderFeeType.Description = Description;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderFeeType Clone()
        {
            var obj = new OrderFeeType();
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
            var sb = new System.Text.StringBuilder("OrderFeeType{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}