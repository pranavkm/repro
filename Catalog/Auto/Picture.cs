using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of picture
    /// </summary>
    [Table("picture")]
    [DataContract]
    public partial class Picture
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Picture"/>的构造函数
        /// </summary>
        public Picture()
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
        /// 服务器文件路径
        /// </summary>
        [Column("file_path")]
        [DataMember(Order = 1)]
        [StringLength(300)]
        public string FilePath { get; set; } = string.Empty;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 2)]
        [StringLength(300)]
        public string Title { get; set; } = string.Empty;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 3)]
        [StringLength(4000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 图片类型
        /// </summary>
        [Column("picture_type_id")]
        [DataMember(Order = 4)]
        public int PictureTypeId { get; set; } = 0;      	
        /// <summary>
        /// 图片源Id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 5)]
        public long? SourceId { get; set; } = null;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 6)]
        public long UserId { get; set; } = (long)0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 7)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 8)]
        public int? ApplicationId { get; set; } = null;      	
        /// <summary>
        /// 存储类型,1=本地磁盘,2=AliyunOss
        /// </summary>
        [Column("storage_type")]
        [DataMember(Order = 9)]
        public int StorageType { get; set; } = (int)1;      	
        /// <summary>
        /// 存储的元数据
        /// </summary>
        [Column("storage_data")]
        [DataMember(Order = 10)]
        [StringLength(2000)]
        public string StorageData { get; set; } = string.Empty;      	
        /// <summary>
        /// 图片url访问地址
        /// </summary>
        [Column("url")]
        [DataMember(Order = 11)]
        [StringLength(500)]
        public string Url { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="picture"></param>        
        public virtual void CopyTo(Picture picture)
        {
            picture.Id = Id;
            picture.FilePath = FilePath;
            picture.Title = Title;
            picture.Description = Description;
            picture.PictureTypeId = PictureTypeId;
            picture.SourceId = SourceId;
            picture.UserId = UserId;
            picture.CreatedOn = CreatedOn;
            picture.ApplicationId = ApplicationId;
            picture.StorageType = StorageType;
            picture.StorageData = StorageData;
            picture.Url = Url;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Picture Clone()
        {
            var obj = new Picture();
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
            var sb = new System.Text.StringBuilder("Picture{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", FilePath='");
            sb.Append(FilePath).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", PictureTypeId='");
            sb.Append(PictureTypeId).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", StorageType='");
            sb.Append(StorageType).AppendLine("'");
            sb.Append(", StorageData='");
            sb.Append(StorageData).AppendLine("'");
            sb.Append(", Url='");
            sb.Append(Url).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}