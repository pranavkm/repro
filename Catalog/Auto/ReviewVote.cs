using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of review_vote
    /// </summary>
    [Table("review_vote")]
    [DataContract]
    public partial class ReviewVote
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ReviewVote"/>的构造函数
        /// </summary>
        public ReviewVote()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 评论id
        /// </summary>
        [Key]
        [Column("review_id")]
        [DataMember(Order = 0)]
        public long ReviewId { get; set; } = 0;      	
        /// <summary>
        /// 用户id
        /// </summary>
        [Key]
        [Column("user_id")]
        [DataMember(Order = 1)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 投票值
        /// </summary>
        [Column("value")]
        [DataMember(Order = 2)]
        public int Value { get; set; } = 0;      	
        /// <summary>
        /// 投票时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 状态1=有效
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="reviewVote"></param>        
        public virtual void CopyTo(ReviewVote reviewVote)
        {
            reviewVote.ReviewId = ReviewId;
            reviewVote.UserId = UserId;
            reviewVote.Value = Value;
            reviewVote.CreatedOn = CreatedOn;
            reviewVote.State = State;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ReviewVote Clone()
        {
            var obj = new ReviewVote();
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
            var sb = new System.Text.StringBuilder("ReviewVote{");
            sb.Append("ReviewId='");
            sb.Append(ReviewId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
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