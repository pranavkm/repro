using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of rating_value
    /// </summary>
    [Table("rating_value")]
    [DataContract]
    public partial class RatingValue
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.RatingValue"/>的构造函数
        /// </summary>
        public RatingValue()
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
        /// 信息Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 评分属性Id
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 2)]
        public int PropertyId { get; set; } = 0;      	
        /// <summary>
        /// 评分属性值Id
        /// </summary>
        [Column("option_id")]
        [DataMember(Order = 3)]
        public int OptionId { get; set; } = 0;      	
        /// <summary>
        /// 用户id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 4)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 分值
        /// </summary>
        [Column("score")]
        [DataMember(Order = 5)]
        public int Score { get; set; } = 0;      	
        /// <summary>
        /// 内容值
        /// </summary>
        [Column("value")]
        [DataMember(Order = 6)]
        [StringLength(1000)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 7)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 添加时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 8)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 评分Id
        /// </summary>
        [Column("rating_id")]
        [DataMember(Order = 9)]
        public long? RatingId { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="ratingValue"></param>        
        public virtual void CopyTo(RatingValue ratingValue)
        {
            ratingValue.Id = Id;
            ratingValue.ItemId = ItemId;
            ratingValue.PropertyId = PropertyId;
            ratingValue.OptionId = OptionId;
            ratingValue.UserId = UserId;
            ratingValue.Score = Score;
            ratingValue.Value = Value;
            ratingValue.State = State;
            ratingValue.CreatedOn = CreatedOn;
            ratingValue.RatingId = RatingId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual RatingValue Clone()
        {
            var obj = new RatingValue();
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
            var sb = new System.Text.StringBuilder("RatingValue{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", OptionId='");
            sb.Append(OptionId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", Score='");
            sb.Append(Score).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", RatingId='");
            sb.Append(RatingId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}