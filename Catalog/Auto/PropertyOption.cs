using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of property_option
    /// </summary>
    [Table("property_option")]
    [DataContract]
    public partial class PropertyOption
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.PropertyOption"/>的构造函数
        /// </summary>
        public PropertyOption()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 标准值Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 标准值编码(唯一)
        /// </summary>
        [Column("code")]
        [DataMember(Order = 1)]
        [StringLength(128)]
        public string Code { get; set; } = string.Empty;      	
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
        public string PropertyName { get; set; } = null;      	
        /// <summary>
        /// 显示值/名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 4)]
        [StringLength(2000)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 原始值/标准值 文本nil表示不限
        /// </summary>
        [Column("value")]
        [DataMember(Order = 5)]
        [StringLength(4000)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 6)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 7)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 8)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 上级标准值Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 9)]
        public int ParentId { get; set; } = (int)0;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 10)]
        [StringLength(8000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 11)]
        public long UserId { get; set; } = (long)0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 12)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 13)]
        public long UpdatedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 14)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据来源
        /// </summary>
        [Column("source_from")]
        [DataMember(Order = 15)]
        [StringLength(128)]
        public string SourceFrom { get; set; } = string.Empty;      	
        /// <summary>
        /// 源数据Id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 16)]
        [StringLength(128)]
        public string SourceId { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="propertyOption"></param>        
        public virtual void CopyTo(PropertyOption propertyOption)
        {
            propertyOption.Id = Id;
            propertyOption.Code = Code;
            propertyOption.PropertyId = PropertyId;
            propertyOption.PropertyName = PropertyName;
            propertyOption.Name = Name;
            propertyOption.Value = Value;
            propertyOption.SortNo = SortNo;
            propertyOption.State = State;
            propertyOption.DataFlags = DataFlags;
            propertyOption.ParentId = ParentId;
            propertyOption.Description = Description;
            propertyOption.UserId = UserId;
            propertyOption.CreatedOn = CreatedOn;
            propertyOption.UpdatedBy = UpdatedBy;
            propertyOption.UpdatedOn = UpdatedOn;
            propertyOption.SourceFrom = SourceFrom;
            propertyOption.SourceId = SourceId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual PropertyOption Clone()
        {
            var obj = new PropertyOption();
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
            var sb = new System.Text.StringBuilder("PropertyOption{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", PropertyName='");
            sb.Append(PropertyName).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", SourceFrom='");
            sb.Append(SourceFrom).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}