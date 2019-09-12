using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_value
    /// </summary>
    [Table("item_value")]
    [DataContract]
    public partial class ItemValue
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemValue"/>的构造函数
        /// </summary>
        public ItemValue()
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
        /// 信息Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 属性Id
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 2)]
        public int PropertyId { get; set; } = 0;      	
        /// <summary>
        /// 属性名
        /// </summary>
        [Column("property_name")]
        [DataMember(Order = 3)]
        [StringLength(255)]
        public string PropertyName { get; set; } = string.Empty;      	
        /// <summary>
        /// 显示值/名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 4)]
        [StringLength(2000)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 原始值/标准值/对象Id
        /// </summary>
        [Column("value")]
        [DataMember(Order = 5)]
        [StringLength(8000)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 6)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 7)]
        public int SortNo { get; set; } = (int)0;      	
        /// <summary>
        /// 上级Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 8)]
        public long ParentId { get; set; } = (long)0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 9)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 11)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 12)]
        [StringLength(4000)]
        public string ExtraData { get; set; } = null;      	
        /// <summary>
        /// 属性值引用类型,0=none,1=option,2=item,3=category,4=region
        /// </summary>
        [Column("reference_type")]
        [DataMember(Order = 13)]
        public int? ReferenceType { get; set; } = null;      	
        /// <summary>
        /// 引用对象Id
        /// </summary>
        [Column("reference_id")]
        [DataMember(Order = 14)]
        [StringLength(64)]
        public string ReferenceId { get; set; } = null;      	
        /// <summary>
        /// 属性编码
        /// </summary>
        [Column("property_code")]
        [DataMember(Order = 15)]
        [StringLength(128)]
        public string PropertyCode { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemValue"></param>        
        public virtual void CopyTo(ItemValue itemValue)
        {
            itemValue.Id = Id;
            itemValue.ItemId = ItemId;
            itemValue.PropertyId = PropertyId;
            itemValue.PropertyName = PropertyName;
            itemValue.Name = Name;
            itemValue.Value = Value;
            itemValue.State = State;
            itemValue.SortNo = SortNo;
            itemValue.ParentId = ParentId;
            itemValue.UserId = UserId;
            itemValue.CreatedOn = CreatedOn;
            itemValue.DataFlags = DataFlags;
            itemValue.ExtraData = ExtraData;
            itemValue.ReferenceType = ReferenceType;
            itemValue.ReferenceId = ReferenceId;
            itemValue.PropertyCode = PropertyCode;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemValue Clone()
        {
            var obj = new ItemValue();
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
            var sb = new System.Text.StringBuilder("ItemValue{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", PropertyName='");
            sb.Append(PropertyName).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", ReferenceType='");
            sb.Append(ReferenceType).AppendLine("'");
            sb.Append(", ReferenceId='");
            sb.Append(ReferenceId).AppendLine("'");
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