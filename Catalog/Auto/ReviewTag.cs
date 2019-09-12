using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of review_tag
    /// </summary>
    [Table("review_tag")]
    [DataContract]
    public partial class ReviewTag
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ReviewTag"/>的构造函数
        /// </summary>
        public ReviewTag()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 评论Id
        /// </summary>
        [Key]
        [Column("review_id")]
        [DataMember(Order = 0)]
        public long ReviewId { get; set; } = 0;      	
        /// <summary>
        /// 标签id
        /// </summary>
        [Key]
        [Column("tag_id")]
        [DataMember(Order = 1)]
        public int TagId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 2)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 标签名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 3)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="reviewTag"></param>        
        public virtual void CopyTo(ReviewTag reviewTag)
        {
            reviewTag.ReviewId = ReviewId;
            reviewTag.TagId = TagId;
            reviewTag.CreatedOn = CreatedOn;
            reviewTag.Name = Name;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ReviewTag Clone()
        {
            var obj = new ReviewTag();
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
            var sb = new System.Text.StringBuilder("ReviewTag{");
            sb.Append("ReviewId='");
            sb.Append(ReviewId).AppendLine("'");
            sb.Append(", TagId='");
            sb.Append(TagId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}