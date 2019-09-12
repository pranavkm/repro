using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of review_value
    /// </summary>
    [Table("review_value")]
    [DataContract]
    public partial class ReviewValue
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ReviewValue"/>的构造函数
        /// </summary>
        public ReviewValue()
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
        /// 评论Id
        /// </summary>
        [Column("review_id")]
        [DataMember(Order = 1)]
        public long ReviewId { get; set; } = 0;      	
        /// <summary>
        /// 评论属性Id
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 2)]
        public int PropertyId { get; set; } = 0;      	
        /// <summary>
        /// 评论属性值Id
        /// </summary>
        [Column("option_id")]
        [DataMember(Order = 3)]
        public int OptionId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 评论项值
        /// </summary>
        [Column("value")]
        [DataMember(Order = 5)]
        [StringLength(8000)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 7)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 信息Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 8)]
        public long ItemId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="reviewValue"></param>        
        public virtual void CopyTo(ReviewValue reviewValue)
        {
            reviewValue.Id = Id;
            reviewValue.ReviewId = ReviewId;
            reviewValue.PropertyId = PropertyId;
            reviewValue.OptionId = OptionId;
            reviewValue.State = State;
            reviewValue.Value = Value;
            reviewValue.CreatedOn = CreatedOn;
            reviewValue.UserId = UserId;
            reviewValue.ItemId = ItemId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ReviewValue Clone()
        {
            var obj = new ReviewValue();
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
            var sb = new System.Text.StringBuilder("ReviewValue{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ReviewId='");
            sb.Append(ReviewId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", OptionId='");
            sb.Append(OptionId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}