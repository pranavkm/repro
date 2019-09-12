using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of user_count
    /// </summary>
    [Table("user_count")]
    [DataContract]
    public partial class UserCount
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.UserCount"/>的构造函数
        /// </summary>
        public UserCount()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 用户id
        /// </summary>
        [Key]
        [Column("user_id")]
        [DataMember(Order = 0)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 统计类型,如查看数，评论数，评分总计
        /// </summary>
        [Key]
        [Column("count_type")]
        [DataMember(Order = 1)]
        public int CountType { get; set; } = 0;      	
        /// <summary>
        /// 计数值
        /// </summary>
        [Column("count")]
        [DataMember(Order = 2)]
        public long Count { get; set; } = (long)0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 4)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 5)]
        [StringLength(8000)]
        public string ExtraData { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="userCount"></param>        
        public virtual void CopyTo(UserCount userCount)
        {
            userCount.UserId = UserId;
            userCount.CountType = CountType;
            userCount.Count = Count;
            userCount.CreatedOn = CreatedOn;
            userCount.UpdatedOn = UpdatedOn;
            userCount.ExtraData = ExtraData;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual UserCount Clone()
        {
            var obj = new UserCount();
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
            var sb = new System.Text.StringBuilder("UserCount{");
            sb.Append("UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CountType='");
            sb.Append(CountType).AppendLine("'");
            sb.Append(", Count='");
            sb.Append(Count).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}