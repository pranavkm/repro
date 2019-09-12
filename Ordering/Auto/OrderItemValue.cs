using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_item_value
    /// </summary>
    [Table("order_item_value")]
    [DataContract]
    public partial class OrderItemValue
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderItemValue"/>的构造函数
        /// </summary>
        public OrderItemValue()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 订单属性值Id
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
        /// sku值id
        /// </summary>
        [Column("sku_value_id")]
        [DataMember(Order = 2)]
        public long SkuValueId { get; set; } = 0;      	
        /// <summary>
        /// 属性Id
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 3)]
        public int PropertyId { get; set; } = 0;      	
        /// <summary>
        /// 属性名
        /// </summary>
        [Column("property_name")]
        [DataMember(Order = 4)]
        [StringLength(255)]
        public string PropertyName { get; set; } = null;      	
        /// <summary>
        /// 显示值/名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 5)]
        [StringLength(4000)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 原始值/标准值/对象Id
        /// </summary>
        [Column("value")]
        [DataMember(Order = 6)]
        [StringLength(4000)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 7)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新人Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 8)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 11)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 12)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 属性编码
        /// </summary>
        [Column("property_code")]
        [DataMember(Order = 13)]
        [StringLength(128)]
        public string PropertyCode { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderItemValue"></param>        
        public virtual void CopyTo(OrderItemValue orderItemValue)
        {
            orderItemValue.Id = Id;
            orderItemValue.OrderItemId = OrderItemId;
            orderItemValue.SkuValueId = SkuValueId;
            orderItemValue.PropertyId = PropertyId;
            orderItemValue.PropertyName = PropertyName;
            orderItemValue.Name = Name;
            orderItemValue.Value = Value;
            orderItemValue.CreatedBy = CreatedBy;
            orderItemValue.UpdatedBy = UpdatedBy;
            orderItemValue.CreatedOn = CreatedOn;
            orderItemValue.UpdatedOn = UpdatedOn;
            orderItemValue.State = State;
            orderItemValue.OrderId = OrderId;
            orderItemValue.PropertyCode = PropertyCode;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderItemValue Clone()
        {
            var obj = new OrderItemValue();
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
            var sb = new System.Text.StringBuilder("OrderItemValue{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderItemId='");
            sb.Append(OrderItemId).AppendLine("'");
            sb.Append(", SkuValueId='");
            sb.Append(SkuValueId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", PropertyName='");
            sb.Append(PropertyName).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", PropertyCode='");
            sb.Append(PropertyCode).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}