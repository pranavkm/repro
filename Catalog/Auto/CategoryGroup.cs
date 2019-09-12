using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category_group
    /// </summary>
    [Table("category_group")]
    [DataContract]
    public partial class CategoryGroup
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CategoryGroup"/>的构造函数
        /// </summary>
        public CategoryGroup()
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
        /// 分组Id
        /// </summary>
        [Column("group_id")]
        [DataMember(Order = 2)]
        public int? GroupId { get; set; } = null;      	
        /// <summary>
        /// 排序，大值排前
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 3)]
        public int? SortNo { get; set; } = null;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 排除属性
        /// </summary>
        [Column("is_excluded")]
        [DataMember(Order = 5)]
        public bool IsExcluded { get; set; } = false;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 6)]
        public long? DataFlags { get; set; } = null;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 7)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 8)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 属性名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 10)]
        [StringLength(200)]
        public string Name { get; set; } = null;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 11)]
        [StringLength(2000)]
        public string Description { get; set; } = null;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 12)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 13)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="categoryGroup"></param>        
        public virtual void CopyTo(CategoryGroup categoryGroup)
        {
            categoryGroup.Id = Id;
            categoryGroup.CategoryId = CategoryId;
            categoryGroup.GroupId = GroupId;
            categoryGroup.SortNo = SortNo;
            categoryGroup.State = State;
            categoryGroup.IsExcluded = IsExcluded;
            categoryGroup.DataFlags = DataFlags;
            categoryGroup.UserId = UserId;
            categoryGroup.CreatedBy = CreatedBy;
            categoryGroup.CreatedOn = CreatedOn;
            categoryGroup.Name = Name;
            categoryGroup.Description = Description;
            categoryGroup.UpdatedBy = UpdatedBy;
            categoryGroup.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CategoryGroup Clone()
        {
            var obj = new CategoryGroup();
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
            var sb = new System.Text.StringBuilder("CategoryGroup{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", GroupId='");
            sb.Append(GroupId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
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
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}