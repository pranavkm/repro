using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of tag
    /// </summary>
    [Table("tag")]
    [DataContract]
    public partial class Tag
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Tag"/>的构造函数
        /// </summary>
        public Tag()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 标签id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 标签编码(唯一)
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
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 首字母缩略词
        /// </summary>
        [Column("acronym")]
        [DataMember(Order = 3)]
        [StringLength(50)]
        public string Acronym { get; set; } = string.Empty;      	
        /// <summary>
        /// url名
        /// </summary>
        [Column("url_name")]
        [DataMember(Order = 4)]
        [StringLength(100)]
        public string UrlName { get; set; } = string.Empty;      	
        /// <summary>
        /// 1=标签组,2=标签值
        /// </summary>
        [Column("tag_type")]
        [DataMember(Order = 5)]
        public int TagType { get; set; } = 0;      	
        /// <summary>
        /// 上级id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 6)]
        public int ParentId { get; set; } = (int)0;      	
        /// <summary>
        /// 状态1=有效
        /// </summary>
        [Column("state")]
        [DataMember(Order = 7)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 8)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 用户id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 9)]
        public long UserId { get; set; } = (long)0;      	
        /// <summary>
        /// 应用id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 10)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 11)]
        [StringLength(8000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据标识
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 12)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 13)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 14)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 15)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="tag"></param>        
        public virtual void CopyTo(Tag tag)
        {
            tag.Id = Id;
            tag.Code = Code;
            tag.Name = Name;
            tag.Acronym = Acronym;
            tag.UrlName = UrlName;
            tag.TagType = TagType;
            tag.ParentId = ParentId;
            tag.State = State;
            tag.SortNo = SortNo;
            tag.UserId = UserId;
            tag.ApplicationId = ApplicationId;
            tag.Description = Description;
            tag.DataFlags = DataFlags;
            tag.CreatedOn = CreatedOn;
            tag.UpdatedBy = UpdatedBy;
            tag.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Tag Clone()
        {
            var obj = new Tag();
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
            var sb = new System.Text.StringBuilder("Tag{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Acronym='");
            sb.Append(Acronym).AppendLine("'");
            sb.Append(", UrlName='");
            sb.Append(UrlName).AppendLine("'");
            sb.Append(", TagType='");
            sb.Append(TagType).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
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