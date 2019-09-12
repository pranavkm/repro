using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of application_setting
    /// </summary>
    [Table("application_setting")]
    [DataContract]
    public partial class ApplicationSetting
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ApplicationSetting"/>的构造函数
        /// </summary>
        public ApplicationSetting()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 应用配置Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 应用类型Id
        /// </summary>
        [Column("application_type_id")]
        [DataMember(Order = 1)]
        public int ApplicationTypeId { get; set; } = 0;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 2)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 配置项Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 3)]
        public int ItemId { get; set; } = 0;      	
        /// <summary>
        /// 配置名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 4)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 配置项Key
        /// </summary>
        [Column("key")]
        [DataMember(Order = 5)]
        [StringLength(500)]
        public string Key { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据类型
        /// </summary>
        [Column("data_type")]
        [DataMember(Order = 6)]
        public int DataType { get; set; } = 0;      	
        /// <summary>
        /// 配置内容
        /// </summary>
        [Column("value")]
        [DataMember(Order = 7)]
        public string Value { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 8)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
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
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 11)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 12)]
        public long UpdatedBy { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="applicationSetting"></param>        
        public virtual void CopyTo(ApplicationSetting applicationSetting)
        {
            applicationSetting.Id = Id;
            applicationSetting.ApplicationTypeId = ApplicationTypeId;
            applicationSetting.ApplicationId = ApplicationId;
            applicationSetting.ItemId = ItemId;
            applicationSetting.Name = Name;
            applicationSetting.Key = Key;
            applicationSetting.DataType = DataType;
            applicationSetting.Value = Value;
            applicationSetting.CreatedOn = CreatedOn;
            applicationSetting.UpdatedOn = UpdatedOn;
            applicationSetting.State = State;
            applicationSetting.CreatedBy = CreatedBy;
            applicationSetting.UpdatedBy = UpdatedBy;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ApplicationSetting Clone()
        {
            var obj = new ApplicationSetting();
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
            var sb = new System.Text.StringBuilder("ApplicationSetting{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ApplicationTypeId='");
            sb.Append(ApplicationTypeId).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Key='");
            sb.Append(Key).AppendLine("'");
            sb.Append(", DataType='");
            sb.Append(DataType).AppendLine("'");
            sb.Append(", Value='");
            sb.Append(Value).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}