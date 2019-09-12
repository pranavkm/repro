using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of sku_value
    /// </summary>
    [Table("sku_value")]
    [DataContract]
    public partial class SkuValue
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.SkuValue"/>的构造函数
        /// </summary>
        public SkuValue()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 商品Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// SkuId
        /// </summary>
        [Column("sku_id")]
        [DataMember(Order = 2)]
        public long SkuId { get; set; } = 0;      	
        /// <summary>
        /// 属性Id
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 3)]
        public int PropertyId { get; set; } = 0;      	
        /// <summary>
        /// 标准值Id
        /// </summary>
        [Column("option_id")]
        [DataMember(Order = 4)]
        public int OptionId { get; set; } = (int)0;      	
        /// <summary>
        /// 显示值/名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 5)]
        [StringLength(500)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 原始值/标准值
        /// </summary>
        [Column("value")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 属性名
        /// </summary>
        [Column("property_name")]
        [DataMember(Order = 7)]
        [StringLength(200)]
        public string PropertyName { get; set; } = string.Empty;      	
        /// <summary>
        /// 属性编码
        /// </summary>
        [Column("property_code")]
        [DataMember(Order = 8)]
        [StringLength(128)]
        public string PropertyCode { get; set; } = null;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 9)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 类型标识位:1=销售属性(用来生成sku),2=销售扩展属性
        /// </summary>
        [Column("type_flags")]
        [DataMember(Order = 10)]
        public int TypeFlags { get; set; } = (int)0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="skuValue"></param>        
        public virtual void CopyTo(SkuValue skuValue)
        {
            skuValue.Id = Id;
            skuValue.ItemId = ItemId;
            skuValue.SkuId = SkuId;
            skuValue.PropertyId = PropertyId;
            skuValue.OptionId = OptionId;
            skuValue.Name = Name;
            skuValue.Value = Value;
            skuValue.PropertyName = PropertyName;
            skuValue.PropertyCode = PropertyCode;
            skuValue.DataFlags = DataFlags;
            skuValue.TypeFlags = TypeFlags;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual SkuValue Clone()
        {
            var obj = new SkuValue();
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
            var sb = new System.Text.StringBuilder("SkuValue{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", SkuId='");
            sb.Append(SkuId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", OptionId='");
            sb.Append(OptionId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", PropertyName='");
            sb.Append(PropertyName).AppendLine("'");
            sb.Append(", PropertyCode='");
            sb.Append(PropertyCode).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", TypeFlags='");
            sb.Append(TypeFlags).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}