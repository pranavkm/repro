using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_visit
    /// </summary>
    [Table("item_visit")]
    [DataContract]
    public partial class ItemVisit
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemVisit"/>的构造函数
        /// </summary>
        public ItemVisit()
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
        /// 用户Id
        /// </summary>
        [Key]
        [Column("user_id")]
        [DataMember(Order = 1)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 最后访问时间
        /// </summary>
        [Column("visited_time")]
        [DataMember(Order = 2)]
        public DateTimeOffset VisitedTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 3)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemVisit"></param>        
        public virtual void CopyTo(ItemVisit itemVisit)
        {
            itemVisit.ItemId = ItemId;
            itemVisit.UserId = UserId;
            itemVisit.VisitedTime = VisitedTime;
            itemVisit.ApplicationId = ApplicationId;
            itemVisit.State = State;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemVisit Clone()
        {
            var obj = new ItemVisit();
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
            var sb = new System.Text.StringBuilder("ItemVisit{");
            sb.Append("ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", VisitedTime='");
            sb.Append(VisitedTime).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
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