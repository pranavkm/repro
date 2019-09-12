using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category_source
    /// </summary>
    [Table("category_source")]
    [DataContract]
    public partial class CategorySource
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CategorySource"/>的构造函数
        /// </summary>
        public CategorySource()
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
        /// url地址
        /// </summary>
        [Column("url")]
        [DataMember(Order = 1)]
        [StringLength(500)]
        public string Url { get; set; } = string.Empty;      	
        /// <summary>
        /// 外部数据的Id
        /// </summary>
        [Column("unique_id")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string UniqueId { get; set; } = string.Empty;      	
        /// <summary>
        /// 添加时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 4)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 上级Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 5)]
        public int ParentId { get; set; } = 0;      	
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 6)]
        public string ExtraData { get; set; } = null;      	
        /// <summary>
        /// 外部来源名(如amazon)
        /// </summary>
        [Column("source_name")]
        [DataMember(Order = 7)]
        [StringLength(100)]
        public string SourceName { get; set; } = string.Empty;      	
        /// <summary>
        /// 映射的系统分类Id
        /// </summary>
        [Column("category_id")]
        [DataMember(Order = 8)]
        public int? CategoryId { get; set; } = null;      	
        /// <summary>
        /// 状态1=有效
        /// </summary>
        [Column("state")]
        [DataMember(Order = 9)]
        public int State { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="categorySource"></param>        
        public virtual void CopyTo(CategorySource categorySource)
        {
            categorySource.Id = Id;
            categorySource.Url = Url;
            categorySource.UniqueId = UniqueId;
            categorySource.CreatedOn = CreatedOn;
            categorySource.Name = Name;
            categorySource.ParentId = ParentId;
            categorySource.ExtraData = ExtraData;
            categorySource.SourceName = SourceName;
            categorySource.CategoryId = CategoryId;
            categorySource.State = State;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CategorySource Clone()
        {
            var obj = new CategorySource();
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
            var sb = new System.Text.StringBuilder("CategorySource{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Url='");
            sb.Append(Url).AppendLine("'");
            sb.Append(", UniqueId='");
            sb.Append(UniqueId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", SourceName='");
            sb.Append(SourceName).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}