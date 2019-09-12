using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of review
    /// </summary>
    [Table("review")]
    [DataContract]
    public partial class Review
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Review"/>的构造函数
        /// </summary>
        public Review()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 评论Id
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 信息Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 2)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 3)]
        [StringLength(300)]
        public string Title { get; set; } = string.Empty;      	
        /// <summary>
        /// 内容
        /// </summary>
        [Column("content")]
        [DataMember(Order = 4)]
        [StringLength(2000)]
        public string Content { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 5)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 添加时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据标志位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 7)]
        public long DataFlags { get; set; } = (long)0;      	
        /// <summary>
        /// 上级评论Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 8)]
        public long ParentId { get; set; } = (long)0;      	
        /// <summary>
        /// 顶级评论Id,如果没有为本身id
        /// </summary>
        [Column("top_id")]
        [DataMember(Order = 9)]
        public long TopId { get; set; } = (long)0;      	
        /// <summary>
        /// 上级评论Id路径,如(,1,22,53,)
        /// </summary>
        [Column("parent_path")]
        [DataMember(Order = 10)]
        [StringLength(1000)]
        public string ParentPath { get; set; } = string.Empty;      	
        /// <summary>
        /// 是否有回复
        /// </summary>
        [Column("has_children")]
        [DataMember(Order = 11)]
        public bool HasChildren { get; set; } = false;      	
        /// <summary>
        /// 原始来源id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 12)]
        public long SourceId { get; set; } = 0;      	
        /// <summary>
        /// 关联的信息评分id(rating)
        /// </summary>
        [Column("rating_id")]
        [DataMember(Order = 13)]
        public long RatingId { get; set; } = (long)0;      	
        /// <summary>
        /// 图片数量
        /// </summary>
        [Column("picture_count")]
        [DataMember(Order = 14)]
        public int PictureCount { get; set; } = (int)0;      	
        /// <summary>
        /// 客户端ip
        /// </summary>
        [Column("from_ip")]
        [DataMember(Order = 15)]
        [StringLength(64)]
        public string FromIp { get; set; } = string.Empty;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 16)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 评论针对的用户Id
        /// </summary>
        [Column("to_user_id")]
        [DataMember(Order = 17)]
        public long ToUserId { get; set; } = 0;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 18)]
        public int ApplicationId { get; set; } = 0;      	
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
        public long UpdatedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 审核状态
        /// </summary>
        [Column("audit_state")]
        [DataMember(Order = 21)]
        public int AuditState { get; set; } = (int)0;      	
        /// <summary>
        /// 信息评分值
        /// </summary>
        [Column("score")]
        [DataMember(Order = 22)]
        public int? Score { get; set; } = null;      	
        /// <summary>
        /// 回复数量
        /// </summary>
        [Column("child_count")]
        [DataMember(Order = 23)]
        public int ChildCount { get; set; } = (int)0;      	
        /// <summary>
        /// 级别
        /// </summary>
        [Column("level")]
        [DataMember(Order = 24)]
        public int Level { get; set; } = (int)0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="review"></param>        
        public virtual void CopyTo(Review review)
        {
            review.Id = Id;
            review.ItemId = ItemId;
            review.UserId = UserId;
            review.Title = Title;
            review.Content = Content;
            review.State = State;
            review.CreatedOn = CreatedOn;
            review.DataFlags = DataFlags;
            review.ParentId = ParentId;
            review.TopId = TopId;
            review.ParentPath = ParentPath;
            review.HasChildren = HasChildren;
            review.SourceId = SourceId;
            review.RatingId = RatingId;
            review.PictureCount = PictureCount;
            review.FromIp = FromIp;
            review.SortNo = SortNo;
            review.ToUserId = ToUserId;
            review.ApplicationId = ApplicationId;
            review.UpdatedOn = UpdatedOn;
            review.UpdatedBy = UpdatedBy;
            review.AuditState = AuditState;
            review.Score = Score;
            review.ChildCount = ChildCount;
            review.Level = Level;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Review Clone()
        {
            var obj = new Review();
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
            var sb = new System.Text.StringBuilder("Review{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Content='");
            sb.Append(Content).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", TopId='");
            sb.Append(TopId).AppendLine("'");
            sb.Append(", ParentPath='");
            sb.Append(ParentPath).AppendLine("'");
            sb.Append(", HasChildren='");
            sb.Append(HasChildren).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append(", RatingId='");
            sb.Append(RatingId).AppendLine("'");
            sb.Append(", PictureCount='");
            sb.Append(PictureCount).AppendLine("'");
            sb.Append(", FromIp='");
            sb.Append(FromIp).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", ToUserId='");
            sb.Append(ToUserId).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", AuditState='");
            sb.Append(AuditState).AppendLine("'");
            sb.Append(", Score='");
            sb.Append(Score).AppendLine("'");
            sb.Append(", ChildCount='");
            sb.Append(ChildCount).AppendLine("'");
            sb.Append(", Level='");
            sb.Append(Level).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}