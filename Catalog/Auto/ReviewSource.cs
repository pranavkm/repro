using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of review_source
    /// </summary>
    [Table("review_source")]
    [DataContract]
    public partial class ReviewSource
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ReviewSource"/>的构造函数
        /// </summary>
        public ReviewSource()
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
        public long Id { get; set; } = 0;      	
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
        /// 相关数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 5)]
        public string ExtraData { get; set; } = null;      	
        /// <summary>
        /// 外部来源名(如amazon)
        /// </summary>
        [Column("source_name")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string SourceName { get; set; } = string.Empty;      	
        /// <summary>
        /// 状态1=有效
        /// </summary>
        [Column("state")]
        [DataMember(Order = 7)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 评论Id
        /// </summary>
        [Column("review_id")]
        [DataMember(Order = 8)]
        public long? ReviewId { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="reviewSource"></param>        
        public virtual void CopyTo(ReviewSource reviewSource)
        {
            reviewSource.Id = Id;
            reviewSource.Url = Url;
            reviewSource.UniqueId = UniqueId;
            reviewSource.CreatedOn = CreatedOn;
            reviewSource.Name = Name;
            reviewSource.ExtraData = ExtraData;
            reviewSource.SourceName = SourceName;
            reviewSource.State = State;
            reviewSource.ReviewId = ReviewId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ReviewSource Clone()
        {
            var obj = new ReviewSource();
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
            var sb = new System.Text.StringBuilder("ReviewSource{");
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
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", SourceName='");
            sb.Append(SourceName).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", ReviewId='");
            sb.Append(ReviewId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}