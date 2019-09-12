using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of user_visit
    /// </summary>
    [Table("user_visit")]
    [DataContract]
    public partial class UserVisit
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.UserVisit"/>的构造函数
        /// </summary>
        public UserVisit()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 被访问的用户/博主Id
        /// </summary>
        [Key]
        [Column("visited_id")]
        [DataMember(Order = 0)]
        public long VisitedId { get; set; } = 0;      	
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
        /// <param name="userVisit"></param>        
        public virtual void CopyTo(UserVisit userVisit)
        {
            userVisit.VisitedId = VisitedId;
            userVisit.UserId = UserId;
            userVisit.VisitedTime = VisitedTime;
            userVisit.ApplicationId = ApplicationId;
            userVisit.State = State;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual UserVisit Clone()
        {
            var obj = new UserVisit();
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
            var sb = new System.Text.StringBuilder("UserVisit{");
            sb.Append("VisitedId='");
            sb.Append(VisitedId).AppendLine("'");
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