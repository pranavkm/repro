using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of picture_source
    /// </summary>
    [Table("picture_source")]
    [DataContract]
    public partial class PictureSource
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.PictureSource"/>的构造函数
        /// </summary>
        public PictureSource()
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
        /// 外部来源名(如amazon)
        /// </summary>
        [Column("source_name")]
        [DataMember(Order = 1)]
        [StringLength(100)]
        public string SourceName { get; set; } = string.Empty;      	
        /// <summary>
        /// url地址
        /// </summary>
        [Column("url")]
        [DataMember(Order = 2)]
        [StringLength(500)]
        public string Url { get; set; } = string.Empty;      	
        /// <summary>
        /// 外部数据Id
        /// </summary>
        [Column("unique_id")]
        [DataMember(Order = 3)]
        [StringLength(200)]
        public string UniqueId { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 4)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 5)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset? UpdatedOn { get; set; } = null;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 7)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 相关数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 8)]
        public string ExtraData { get; set; } = null;      	
        /// <summary>
        /// 引用源url
        /// </summary>
        [Column("referrer")]
        [DataMember(Order = 9)]
        [StringLength(500)]
        public string Referrer { get; set; } = null;      	
        /// <summary>
        /// 图片Id
        /// </summary>
        [Column("picture_id")]
        [DataMember(Order = 10)]
        public long PictureId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="pictureSource"></param>        
        public virtual void CopyTo(PictureSource pictureSource)
        {
            pictureSource.Id = Id;
            pictureSource.SourceName = SourceName;
            pictureSource.Url = Url;
            pictureSource.UniqueId = UniqueId;
            pictureSource.CreatedBy = CreatedBy;
            pictureSource.CreatedOn = CreatedOn;
            pictureSource.UpdatedOn = UpdatedOn;
            pictureSource.Name = Name;
            pictureSource.ExtraData = ExtraData;
            pictureSource.Referrer = Referrer;
            pictureSource.PictureId = PictureId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual PictureSource Clone()
        {
            var obj = new PictureSource();
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
            var sb = new System.Text.StringBuilder("PictureSource{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", SourceName='");
            sb.Append(SourceName).AppendLine("'");
            sb.Append(", Url='");
            sb.Append(Url).AppendLine("'");
            sb.Append(", UniqueId='");
            sb.Append(UniqueId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", Referrer='");
            sb.Append(Referrer).AppendLine("'");
            sb.Append(", PictureId='");
            sb.Append(PictureId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}