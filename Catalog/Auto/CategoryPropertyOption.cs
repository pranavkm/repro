using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category_property_option
    /// </summary>
    [Table("category_property_option")]
    [DataContract]
    public partial class CategoryPropertyOption
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CategoryPropertyOption"/>的构造函数
        /// </summary>
        public CategoryPropertyOption()
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
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 分类属性Id
        /// </summary>
        [Column("category_property_id")]
        [DataMember(Order = 1)]
        public int CategoryPropertyId { get; set; } = 0;      	
        /// <summary>
        /// 分类Id
        /// </summary>
        [Column("category_id")]
        [DataMember(Order = 2)]
        public int CategoryId { get; set; } = 0;      	
        /// <summary>
        /// 属性Id
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 3)]
        public int? PropertyId { get; set; } = null;      	
        /// <summary>
        /// 标准值Id
        /// </summary>
        [Column("option_id")]
        [DataMember(Order = 4)]
        public int? OptionId { get; set; } = null;      	
        /// <summary>
        /// 显示值/名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 5)]
        [StringLength(2000)]
        public string Name { get; set; } = null;      	
        /// <summary>
        /// 原始值/标准值 文本nil表示不限
        /// </summary>
        [Column("value")]
        [DataMember(Order = 6)]
        [StringLength(4000)]
        public string Value { get; set; } = null;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 7)]
        public int? SortNo { get; set; } = null;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 9)]
        public long? DataFlags { get; set; } = null;      	
        /// <summary>
        /// 上级id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 10)]
        public int? ParentId { get; set; } = null;      	
        /// <summary>
        /// 属性名
        /// </summary>
        [Column("property_name")]
        [DataMember(Order = 11)]
        [StringLength(200)]
        public string PropertyName { get; set; } = null;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 12)]
        [StringLength(8000)]
        public string Description { get; set; } = null;      	
        /// <summary>
        /// 排除标准值
        /// </summary>
        [Column("is_excluded")]
        [DataMember(Order = 13)]
        public bool IsExcluded { get; set; } = false;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 14)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 15)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 16)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="categoryPropertyOption"></param>        
        public virtual void CopyTo(CategoryPropertyOption categoryPropertyOption)
        {
            categoryPropertyOption.Id = Id;
            categoryPropertyOption.CategoryPropertyId = CategoryPropertyId;
            categoryPropertyOption.CategoryId = CategoryId;
            categoryPropertyOption.PropertyId = PropertyId;
            categoryPropertyOption.OptionId = OptionId;
            categoryPropertyOption.Name = Name;
            categoryPropertyOption.Value = Value;
            categoryPropertyOption.SortNo = SortNo;
            categoryPropertyOption.State = State;
            categoryPropertyOption.DataFlags = DataFlags;
            categoryPropertyOption.ParentId = ParentId;
            categoryPropertyOption.PropertyName = PropertyName;
            categoryPropertyOption.Description = Description;
            categoryPropertyOption.IsExcluded = IsExcluded;
            categoryPropertyOption.UserId = UserId;
            categoryPropertyOption.CreatedBy = CreatedBy;
            categoryPropertyOption.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CategoryPropertyOption Clone()
        {
            var obj = new CategoryPropertyOption();
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
            var sb = new System.Text.StringBuilder("CategoryPropertyOption{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", CategoryPropertyId='");
            sb.Append(CategoryPropertyId).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", OptionId='");
            sb.Append(OptionId).AppendLine("'");
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
            sb.Append(", PropertyName='");
            sb.Append(PropertyName).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", IsExcluded='");
            sb.Append(IsExcluded).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
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