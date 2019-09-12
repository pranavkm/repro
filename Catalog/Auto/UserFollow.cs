using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of user_follow
    /// </summary>
    [Table("user_follow")]
    [DataContract]
    public partial class UserFollow
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.UserFollow"/>的构造函数
        /// </summary>
        public UserFollow()
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
        /// 类型:1=关注2=加入3=点赞
        /// </summary>
        [Column("follow_type")]
        [DataMember(Order = 1)]
        public int FollowType { get; set; } = 0;      	
        /// <summary>
        /// 相关的用户Id
        /// </summary>
        [Column("follow_user_id")]
        [DataMember(Order = 2)]
        public long FollowUserId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 3)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 4)]
        public long UserId { get; set; } = (long)0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 5)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 添加时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 扩展数据，如微信号
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 7)]
        [StringLength(8000)]
        public string ExtraData { get; set; } = null;      	
        /// <summary>
        /// 审核状态
        /// </summary>
        [Column("audit_state")]
        [DataMember(Order = 8)]
        public int AuditState { get; set; } = (int)0;      	
        /// <summary>
        /// 审核用户Id
        /// </summary>
        [Column("audited_by")]
        [DataMember(Order = 9)]
        public long AuditedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 审核时间
        /// </summary>
        [Column("audited_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset? AuditedOn { get; set; } = null;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 11)]
        public long UpdatedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 12)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 13)]
        public int ApplicationId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="userFollow"></param>        
        public virtual void CopyTo(UserFollow userFollow)
        {
            userFollow.Id = Id;
            userFollow.FollowType = FollowType;
            userFollow.FollowUserId = FollowUserId;
            userFollow.State = State;
            userFollow.UserId = UserId;
            userFollow.CreatedBy = CreatedBy;
            userFollow.CreatedOn = CreatedOn;
            userFollow.ExtraData = ExtraData;
            userFollow.AuditState = AuditState;
            userFollow.AuditedBy = AuditedBy;
            userFollow.AuditedOn = AuditedOn;
            userFollow.UpdatedBy = UpdatedBy;
            userFollow.UpdatedOn = UpdatedOn;
            userFollow.ApplicationId = ApplicationId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual UserFollow Clone()
        {
            var obj = new UserFollow();
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
            var sb = new System.Text.StringBuilder("UserFollow{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", FollowType='");
            sb.Append(FollowType).AppendLine("'");
            sb.Append(", FollowUserId='");
            sb.Append(FollowUserId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", AuditState='");
            sb.Append(AuditState).AppendLine("'");
            sb.Append(", AuditedBy='");
            sb.Append(AuditedBy).AppendLine("'");
            sb.Append(", AuditedOn='");
            sb.Append(AuditedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}