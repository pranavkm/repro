using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of contributor
    /// </summary>
    [Table("contributor")]
    [DataContract]
    public partial class Contributor
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Contributor"/>的构造函数
        /// </summary>
        public Contributor()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 1)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 展示名称(如博主名)
        /// </summary>
        [Column("name")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 3)]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 标签
        /// </summary>
        [Column("tags")]
        [DataMember(Order = 4)]
        [StringLength(500)]
        public string Tags { get; set; } = string.Empty;      	
        /// <summary>
        /// 归属类型
        /// </summary>
        [Column("type")]
        [DataMember(Order = 5)]
        public int Type { get; set; } = 0;      	
        /// <summary>
        /// 创建用户id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 6)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 7)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 8)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 10)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 头像
        /// </summary>
        [Column("avatar")]
        [DataMember(Order = 11)]
        [StringLength(300)]
        public string Avatar { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="contributor"></param>        
        public virtual void CopyTo(Contributor contributor)
        {
            contributor.Id = Id;
            contributor.UserId = UserId;
            contributor.Name = Name;
            contributor.Description = Description;
            contributor.Tags = Tags;
            contributor.Type = Type;
            contributor.CreatedBy = CreatedBy;
            contributor.CreatedOn = CreatedOn;
            contributor.UpdatedBy = UpdatedBy;
            contributor.UpdatedOn = UpdatedOn;
            contributor.State = State;
            contributor.Avatar = Avatar;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Contributor Clone()
        {
            var obj = new Contributor();
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
            var sb = new System.Text.StringBuilder("Contributor{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", Tags='");
            sb.Append(Tags).AppendLine("'");
            sb.Append(", Type='");
            sb.Append(Type).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", Avatar='");
            sb.Append(Avatar).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}