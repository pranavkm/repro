using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of property
    /// </summary>
    [Table("property")]
    [DataContract]
    public partial class Property
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Property"/>的构造函数
        /// </summary>
        public Property()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 属性id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 属性编码(唯一)
        /// </summary>
        [Column("code")]
        [DataMember(Order = 1)]
        [StringLength(128)]
        public string Code { get; set; } = string.Empty;      	
        /// <summary>
        /// 分类Id
        /// </summary>
        [Column("category_id")]
        [DataMember(Order = 2)]
        public int CategoryId { get; set; } = 0;      	
        /// <summary>
        /// 分组Id
        /// </summary>
        [Column("group_id")]
        [DataMember(Order = 3)]
        public int GroupId { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 4)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 5)]
        [StringLength(2000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 6)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 7)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 适用类型:0=unknown,1=item模板属性,2=分类(category),3=变量(Variation),4=item自定义属性
        /// </summary>
        [Column("apply_type")]
        [DataMember(Order = 8)]
        public int ApplyType { get; set; } = (int)0;      	
        /// <summary>
        /// 1=字符串,2=整形,3=日期,4=浮点型,5=布尔类型,6=GeoPoint,99=引用类型
        /// </summary>
        [Column("data_type")]
        [DataMember(Order = 9)]
        public int DataType { get; set; } = 0;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 10)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 类型标识位:1=销售属性(用来生成sku)
        /// </summary>
        [Column("type_flags")]
        [DataMember(Order = 11)]
        public int TypeFlags { get; set; } = (int)0;      	
        /// <summary>
        /// 用途:1=属性定义,2=内容定义
        /// </summary>
        [Column("usage_mode")]
        [DataMember(Order = 12)]
        public int UsageMode { get; set; } = (int)1;      	
        /// <summary>
        /// 是否可以多值
        /// </summary>
        [Column("is_multiple")]
        [DataMember(Order = 13)]
        public bool IsMultiple { get; set; } = false;      	
        /// <summary>
        /// 是否必填
        /// </summary>
        [Column("is_required")]
        [DataMember(Order = 14)]
        public bool IsRequired { get; set; } = false;      	
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 15)]
        public string ExtraData { get; set; } = "NULL";      	
        /// <summary>
        /// 上级属性Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 16)]
        public int ParentId { get; set; } = (int)0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 17)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 18)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 19)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 20)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 索引方式 0=不索引,1=es索引,2=其他
        /// </summary>
        [Column("index_mode")]
        [DataMember(Order = 21)]
        public int IndexMode { get; set; } = (int)0;      	
        /// <summary>
        /// 验证的表达式，null或空字符表示未设置
        /// </summary>
        [Column("validate_expression")]
        [DataMember(Order = 22)]
        [StringLength(2000)]
        public string ValidateExpression { get; set; } = string.Empty;      	
        /// <summary>
        /// 验证的错误提示
        /// </summary>
        [Column("validate_error")]
        [DataMember(Order = 23)]
        [StringLength(500)]
        public string ValidateError { get; set; } = string.Empty;      	
        /// <summary>
        /// 组件类型,0=默认文本框,1=下拉列表,2=多选框,3=多行文本区域
        /// </summary>
        [Column("widget_type")]
        [DataMember(Order = 24)]
        public int WidgetType { get; set; } = (int)0;      	
        /// <summary>
        /// 属性值引用类型,0=none,1=option,2=item,3=category,4=region
        /// </summary>
        [Column("reference_type")]
        [DataMember(Order = 25)]
        public int? ReferenceType { get; set; } = null;      	
        /// <summary>
        /// 信息id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 26)]
        public long ItemId { get; set; } = (long)0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="property"></param>        
        public virtual void CopyTo(Property property)
        {
            property.Id = Id;
            property.Code = Code;
            property.CategoryId = CategoryId;
            property.GroupId = GroupId;
            property.Name = Name;
            property.Description = Description;
            property.State = State;
            property.SortNo = SortNo;
            property.ApplyType = ApplyType;
            property.DataType = DataType;
            property.DataFlags = DataFlags;
            property.TypeFlags = TypeFlags;
            property.UsageMode = UsageMode;
            property.IsMultiple = IsMultiple;
            property.IsRequired = IsRequired;
            property.ExtraData = ExtraData;
            property.ParentId = ParentId;
            property.UserId = UserId;
            property.CreatedOn = CreatedOn;
            property.UpdatedOn = UpdatedOn;
            property.UpdatedBy = UpdatedBy;
            property.IndexMode = IndexMode;
            property.ValidateExpression = ValidateExpression;
            property.ValidateError = ValidateError;
            property.WidgetType = WidgetType;
            property.ReferenceType = ReferenceType;
            property.ItemId = ItemId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Property Clone()
        {
            var obj = new Property();
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
            var sb = new System.Text.StringBuilder("Property{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", GroupId='");
            sb.Append(GroupId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", ApplyType='");
            sb.Append(ApplyType).AppendLine("'");
            sb.Append(", DataType='");
            sb.Append(DataType).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", TypeFlags='");
            sb.Append(TypeFlags).AppendLine("'");
            sb.Append(", UsageMode='");
            sb.Append(UsageMode).AppendLine("'");
            sb.Append(", IsMultiple='");
            sb.Append(IsMultiple).AppendLine("'");
            sb.Append(", IsRequired='");
            sb.Append(IsRequired).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", IndexMode='");
            sb.Append(IndexMode).AppendLine("'");
            sb.Append(", ValidateExpression='");
            sb.Append(ValidateExpression).AppendLine("'");
            sb.Append(", ValidateError='");
            sb.Append(ValidateError).AppendLine("'");
            sb.Append(", WidgetType='");
            sb.Append(WidgetType).AppendLine("'");
            sb.Append(", ReferenceType='");
            sb.Append(ReferenceType).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}