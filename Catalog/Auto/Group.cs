using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of group
    /// </summary>
    [Table("group")]
    [DataContract]
    public partial class Group
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Group"/>的构造函数
        /// </summary>
        public Group()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 属性组Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 默认分类Id
        /// </summary>
        [Column("category_id")]
        [DataMember(Order = 1)]
        public int CategoryId { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 3)]
        [StringLength(2000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 5)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 6)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 上级Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 7)]
        public int ParentId { get; set; } = (int)0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 8)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 9)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 11)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 12)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 顶级Id
        /// </summary>
        [Column("top_id")]
        [DataMember(Order = 13)]
        public int TopId { get; set; } = (int)0;      	
        /// <summary>
        /// 类型,1=属性组,2=图片组,3文件组
        /// </summary>
        [Column("type")]
        [DataMember(Order = 14)]
        public int Type { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="group"></param>        
        public virtual void CopyTo(Group group)
        {
            group.Id = Id;
            group.CategoryId = CategoryId;
            group.Name = Name;
            group.Description = Description;
            group.State = State;
            group.SortNo = SortNo;
            group.DataFlags = DataFlags;
            group.ParentId = ParentId;
            group.UserId = UserId;
            group.CreatedBy = CreatedBy;
            group.CreatedOn = CreatedOn;
            group.UpdatedBy = UpdatedBy;
            group.UpdatedOn = UpdatedOn;
            group.TopId = TopId;
            group.Type = Type;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Group Clone()
        {
            var obj = new Group();
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
            var sb = new System.Text.StringBuilder("Group{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", TopId='");
            sb.Append(TopId).AppendLine("'");
            sb.Append(", Type='");
            sb.Append(Type).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}