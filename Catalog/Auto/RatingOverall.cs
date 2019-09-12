using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of rating_overall
    /// </summary>
    [Table("rating_overall")]
    [DataContract]
    public partial class RatingOverall
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.RatingOverall"/>的构造函数
        /// </summary>
        public RatingOverall()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 信息Id
        /// </summary>
        [Key]
        [Column("item_id")]
        [DataMember(Order = 0)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 总计分数
        /// </summary>
        [Column("total_score")]
        [DataMember(Order = 1)]
        public long TotalScore { get; set; } = 0;      	
        /// <summary>
        /// 总计人数
        /// </summary>
        [Column("count")]
        [DataMember(Order = 2)]
        public int Count { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="ratingOverall"></param>        
        public virtual void CopyTo(RatingOverall ratingOverall)
        {
            ratingOverall.ItemId = ItemId;
            ratingOverall.TotalScore = TotalScore;
            ratingOverall.Count = Count;
            ratingOverall.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual RatingOverall Clone()
        {
            var obj = new RatingOverall();
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
            var sb = new System.Text.StringBuilder("RatingOverall{");
            sb.Append("ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", TotalScore='");
            sb.Append(TotalScore).AppendLine("'");
            sb.Append(", Count='");
            sb.Append(Count).AppendLine("'");
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