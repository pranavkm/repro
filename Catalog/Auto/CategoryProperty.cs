using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category_property
    /// </summary>
    [Table("category_property")]
    [DataContract]
    public partial class CategoryProperty
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CategoryProperty"/>的构造函数
        /// </summary>
        public CategoryProperty()
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
        /// 分类Id
        /// </summary>
        [Column("category_id")]
        [DataMember(Order = 1)]
        public int CategoryId { get; set; } = 0;      	
        /// <summary>
        /// 属性Id，null=新属性
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 2)]
        public int? PropertyId { get; set; } = null;      	
        /// <summary>
        /// 分组Id
        /// </summary>
        [Column("group_id")]
        [DataMember(Order = 3)]
        public int? GroupId { get; set; } = null;      	
        /// <summary>
        /// 排序，大值排前
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 4)]
        public int? SortNo { get; set; } = null;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 5)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 是否必填，null表示未设置，使用property表里的设置
        /// </summary>
        [Column("is_required")]
        [DataMember(Order = 6)]
        public bool? IsRequired { get; set; } = null;      	
        /// <summary>
        /// 验证的正则表达式，null或空字符表示未设置，使用property表里的设置
        /// </summary>
        [Column("validate_expression")]
        [DataMember(Order = 7)]
        [StringLength(2000)]
        public string ValidateExpression { get; set; } = null;      	
        /// <summary>
        /// 验证的错误提示
        /// </summary>
        [Column("validate_error")]
        [DataMember(Order = 8)]
        [StringLength(500)]
        public string ValidateError { get; set; } = null;      	
        /// <summary>
        /// 是否可以多值,null表示未设置，使用property表里的设置
        /// </summary>
        [Column("is_multi_value")]
        [DataMember(Order = 9)]
        public bool? IsMultiValue { get; set; } = null;      	
        /// <summary>
        /// 组件类型,0=默认文本框,1=下拉列表,2=多选框,3=多行文本区域
        /// </summary>
        [Column("widget_type")]
        [DataMember(Order = 10)]
        public int? WidgetType { get; set; } = null;      	
        /// <summary>
        /// 排除属性
        /// </summary>
        [Column("is_excluded")]
        [DataMember(Order = 11)]
        public bool IsExcluded { get; set; } = false;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 12)]
        public long? DataFlags { get; set; } = null;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 13)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 14)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 15)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 上级Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 16)]
        public int ParentId { get; set; } = 0;      	
        /// <summary>
        /// 属性名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 17)]
        [StringLength(200)]
        public string Name { get; set; } = null;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 18)]
        [StringLength(2000)]
        public string Description { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="categoryProperty"></param>        
        public virtual void CopyTo(CategoryProperty categoryProperty)
        {
            categoryProperty.Id = Id;
            categoryProperty.CategoryId = CategoryId;
            categoryProperty.PropertyId = PropertyId;
            categoryProperty.GroupId = GroupId;
            categoryProperty.SortNo = SortNo;
            categoryProperty.State = State;
            categoryProperty.IsRequired = IsRequired;
            categoryProperty.ValidateExpression = ValidateExpression;
            categoryProperty.ValidateError = ValidateError;
            categoryProperty.IsMultiValue = IsMultiValue;
            categoryProperty.WidgetType = WidgetType;
            categoryProperty.IsExcluded = IsExcluded;
            categoryProperty.DataFlags = DataFlags;
            categoryProperty.UserId = UserId;
            categoryProperty.CreatedBy = CreatedBy;
            categoryProperty.CreatedOn = CreatedOn;
            categoryProperty.ParentId = ParentId;
            categoryProperty.Name = Name;
            categoryProperty.Description = Description;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CategoryProperty Clone()
        {
            var obj = new CategoryProperty();
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
            var sb = new System.Text.StringBuilder("CategoryProperty{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", GroupId='");
            sb.Append(GroupId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", IsRequired='");
            sb.Append(IsRequired).AppendLine("'");
            sb.Append(", ValidateExpression='");
            sb.Append(ValidateExpression).AppendLine("'");
            sb.Append(", ValidateError='");
            sb.Append(ValidateError).AppendLine("'");
            sb.Append(", IsMultiValue='");
            sb.Append(IsMultiValue).AppendLine("'");
            sb.Append(", WidgetType='");
            sb.Append(WidgetType).AppendLine("'");
            sb.Append(", IsExcluded='");
            sb.Append(IsExcluded).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
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