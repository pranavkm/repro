using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of comment
    /// </summary>
    [Table("comment")]
    [DataContract]
    public partial class Comment
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Comment"/>的构造函数
        /// </summary>
        public Comment()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 关联的信息Id
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
        /// 上级Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 8)]
        public long ParentId { get; set; } = (long)0;      	
        /// <summary>
        /// 顶级Id,如果没有为本身id
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
        /// 客户端ip
        /// </summary>
        [Column("from_ip")]
        [DataMember(Order = 13)]
        [StringLength(64)]
        public string FromIp { get; set; } = string.Empty;      	
        /// <summary>
        /// 类型1=问题,2=回答
        /// </summary>
        [Column("type")]
        [DataMember(Order = 14)]
        public int Type { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 15)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 问题针对的用户Id
        /// </summary>
        [Column("to_user_id")]
        [DataMember(Order = 16)]
        public long ToUserId { get; set; } = 0;      	
        /// <summary>
        /// 应用id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 17)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 18)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 19)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="comment"></param>        
        public virtual void CopyTo(Comment comment)
        {
            comment.Id = Id;
            comment.ItemId = ItemId;
            comment.UserId = UserId;
            comment.Title = Title;
            comment.Content = Content;
            comment.State = State;
            comment.CreatedOn = CreatedOn;
            comment.DataFlags = DataFlags;
            comment.ParentId = ParentId;
            comment.TopId = TopId;
            comment.ParentPath = ParentPath;
            comment.HasChildren = HasChildren;
            comment.SourceId = SourceId;
            comment.FromIp = FromIp;
            comment.Type = Type;
            comment.SortNo = SortNo;
            comment.ToUserId = ToUserId;
            comment.ApplicationId = ApplicationId;
            comment.UpdatedBy = UpdatedBy;
            comment.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Comment Clone()
        {
            var obj = new Comment();
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
            var sb = new System.Text.StringBuilder("Comment{");
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
            sb.Append(", FromIp='");
            sb.Append(FromIp).AppendLine("'");
            sb.Append(", Type='");
            sb.Append(Type).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", ToUserId='");
            sb.Append(ToUserId).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
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