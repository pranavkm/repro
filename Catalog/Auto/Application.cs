using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of application
    /// </summary>
    [Table("application")]
    [DataContract]
    public partial class Application
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Application"/>的构造函数
        /// </summary>
        public Application()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 应用Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 应用编码(唯一)
        /// </summary>
        [Column("code")]
        [DataMember(Order = 1)]
        [StringLength(128)]
        public string Code { get; set; } = string.Empty;      	
        /// <summary>
        /// 应用名
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
        [StringLength(8000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 5)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 应用类型1=系统应用定义,2=从系统派生的用户应用实例
        /// </summary>
        [Column("application_type_id")]
        [DataMember(Order = 6)]
        public int ApplicationTypeId { get; set; } = 0;      	
        /// <summary>
        /// url名
        /// </summary>
        [Column("url_name")]
        [DataMember(Order = 7)]
        [StringLength(100)]
        public string UrlName { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 8)]
        public long CreatedBy { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="application"></param>        
        public virtual void CopyTo(Application application)
        {
            application.Id = Id;
            application.Code = Code;
            application.Name = Name;
            application.Description = Description;
            application.State = State;
            application.UserId = UserId;
            application.ApplicationTypeId = ApplicationTypeId;
            application.UrlName = UrlName;
            application.CreatedBy = CreatedBy;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Application Clone()
        {
            var obj = new Application();
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
            var sb = new System.Text.StringBuilder("Application{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", ApplicationTypeId='");
            sb.Append(ApplicationTypeId).AppendLine("'");
            sb.Append(", UrlName='");
            sb.Append(UrlName).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}