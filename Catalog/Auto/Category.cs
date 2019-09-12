using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category
    /// </summary>
    [Table("category")]
    [DataContract]
    public partial class Category
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Category"/>的构造函数
        /// </summary>
        public Category()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 分类Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 分类编码(唯一)
        /// </summary>
        [Column("code")]
        [DataMember(Order = 1)]
        [StringLength(128)]
        public string Code { get; set; } = string.Empty;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// url路径名
        /// </summary>
        [Column("url_name")]
        [DataMember(Order = 3)]
        [StringLength(160)]
        public string UrlName { get; set; } = string.Empty;      	
        /// <summary>
        /// 顶级分类Id
        /// </summary>
        [Column("top_id")]
        [DataMember(Order = 4)]
        public int TopId { get; set; } = (int)0;      	
        /// <summary>
        /// 上级分类Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 5)]
        public int ParentId { get; set; } = (int)0;      	
        /// <summary>
        /// 属性模板分类Id
        /// </summary>
        [Column("template_id")]
        [DataMember(Order = 6)]
        public int TemplateId { get; set; } = (int)0;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 7)]
        [StringLength(8000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 逗号分隔的分类Id路径，包括本分类id
        /// </summary>
        [Column("parent_path")]
        [DataMember(Order = 9)]
        [StringLength(300)]
        public string ParentPath { get; set; } = string.Empty;      	
        /// <summary>
        /// 分类层级
        /// </summary>
        [Column("level")]
        [DataMember(Order = 10)]
        public int Level { get; set; } = 0;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 11)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 来源Id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 12)]
        public int SourceId { get; set; } = (int)0;      	
        /// <summary>
        /// 是否有子节点
        /// </summary>
        [Column("has_children")]
        [DataMember(Order = 13)]
        public bool HasChildren { get; set; } = false;      	
        /// <summary>
        /// 是否属性模板分类
        /// </summary>
        [Column("is_template")]
        [DataMember(Order = 14)]
        public bool IsTemplate { get; set; } = false;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 15)]
        public long CreatedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 创建utc时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 16)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 17)]
        public long UpdatedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 更新utc时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 18)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据标识位1=前台可见,2=后台(用户)可见,4系统(管理)可见,2147483647=全部可见
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 19)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 默认图标路径
        /// </summary>
        [Column("icon")]
        [DataMember(Order = 20)]
        [StringLength(200)]
        public string Icon { get; set; } = string.Empty;      	
        /// <summary>
        /// 系统分类Id
        /// </summary>
        [Column("system_category_id")]
        [DataMember(Order = 21)]
        public int SystemCategoryId { get; set; } = (int)0;      	
        /// <summary>
        /// 排序号，默认升序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 22)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 根分类Id,应用自定义使用方式
        /// </summary>
        [Column("root_id")]
        [DataMember(Order = 23)]
        public int RootId { get; set; } = (int)0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 24)]
        public long UserId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="category"></param>        
        public virtual void CopyTo(Category category)
        {
            category.Id = Id;
            category.Code = Code;
            category.Name = Name;
            category.UrlName = UrlName;
            category.TopId = TopId;
            category.ParentId = ParentId;
            category.TemplateId = TemplateId;
            category.Description = Description;
            category.State = State;
            category.ParentPath = ParentPath;
            category.Level = Level;
            category.ApplicationId = ApplicationId;
            category.SourceId = SourceId;
            category.HasChildren = HasChildren;
            category.IsTemplate = IsTemplate;
            category.CreatedBy = CreatedBy;
            category.CreatedOn = CreatedOn;
            category.UpdatedBy = UpdatedBy;
            category.UpdatedOn = UpdatedOn;
            category.DataFlags = DataFlags;
            category.Icon = Icon;
            category.SystemCategoryId = SystemCategoryId;
            category.SortNo = SortNo;
            category.RootId = RootId;
            category.UserId = UserId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Category Clone()
        {
            var obj = new Category();
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
            var sb = new System.Text.StringBuilder("Category{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", UrlName='");
            sb.Append(UrlName).AppendLine("'");
            sb.Append(", TopId='");
            sb.Append(TopId).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", TemplateId='");
            sb.Append(TemplateId).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", ParentPath='");
            sb.Append(ParentPath).AppendLine("'");
            sb.Append(", Level='");
            sb.Append(Level).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append(", HasChildren='");
            sb.Append(HasChildren).AppendLine("'");
            sb.Append(", IsTemplate='");
            sb.Append(IsTemplate).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", Icon='");
            sb.Append(Icon).AppendLine("'");
            sb.Append(", SystemCategoryId='");
            sb.Append(SystemCategoryId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", RootId='");
            sb.Append(RootId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}