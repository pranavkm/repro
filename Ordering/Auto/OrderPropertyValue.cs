using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_property_value
    /// </summary>
    [Table("order_property_value")]
    [DataContract]
    public partial class OrderPropertyValue
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderPropertyValue"/>的构造函数
        /// </summary>
        public OrderPropertyValue()
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
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 属性编码
        /// </summary>
        [Column("code")]
        [DataMember(Order = 2)]
        [StringLength(100)]
        public string Code { get; set; } = string.Empty;      	
        /// <summary>
        /// 属性名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 3)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 属性值
        /// </summary>
        [Column("value")]
        [DataMember(Order = 4)]
        [StringLength(8000)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 5)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderPropertyValue"></param>        
        public virtual void CopyTo(OrderPropertyValue orderPropertyValue)
        {
            orderPropertyValue.Id = Id;
            orderPropertyValue.OrderId = OrderId;
            orderPropertyValue.Code = Code;
            orderPropertyValue.Name = Name;
            orderPropertyValue.Value = Value;
            orderPropertyValue.CreatedBy = CreatedBy;
            orderPropertyValue.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderPropertyValue Clone()
        {
            var obj = new OrderPropertyValue();
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
            var sb = new System.Text.StringBuilder("OrderPropertyValue{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}