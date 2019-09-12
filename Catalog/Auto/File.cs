using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of file
    /// </summary>
    [Table("file")]
    [DataContract]
    public partial class File
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.File"/>的构造函数
        /// </summary>
        public File()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 服务器文件路径
        /// </summary>
        [Column("file_path")]
        [DataMember(Order = 1)]
        [StringLength(500)]
        public string FilePath { get; set; } = string.Empty;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Title { get; set; } = null;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 3)]
        [StringLength(1000)]
        public string Description { get; set; } = null;      	
        /// <summary>
        /// 访问链接地址
        /// </summary>
        [Column("url")]
        [DataMember(Order = 4)]
        [StringLength(500)]
        public string Url { get; set; } = null;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 5)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 文件大小(byte)
        /// </summary>
        [Column("size")]
        [DataMember(Order = 7)]
        public long Size { get; set; } = 0;      	
        /// <summary>
        /// 文件类型1=图片,2=视频,3=音频
        /// </summary>
        [Column("content_type")]
        [DataMember(Order = 8)]
        public int ContentType { get; set; } = 0;      	
        /// <summary>
        /// 存储类型,1=本地磁盘,2=AliyunOss
        /// </summary>
        [Column("storage_type")]
        [DataMember(Order = 9)]
        public int? StorageType { get; set; } = null;      	
        /// <summary>
        /// 存储的元数据
        /// </summary>
        [Column("storage_data")]
        [DataMember(Order = 10)]
        [StringLength(2000)]
        public string StorageData { get; set; } = null;      	
        /// <summary>
        /// 所属用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 11)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 12)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 13)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 14)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 文件唯一编号
        /// </summary>
        [Column("sn")]
        [DataMember(Order = 15)]
        [StringLength(100)]
        public string Sn { get; set; } = string.Empty;      	
        /// <summary>
        /// 封面图
        /// </summary>
        [Column("cover_url")]
        [DataMember(Order = 16)]
        [StringLength(300)]
        public string CoverUrl { get; set; } = null;      	
        /// <summary>
        /// 元数据类型
        /// </summary>
        [Column("meta_type")]
        [DataMember(Order = 17)]
        [StringLength(100)]
        public string MetaType { get; set; } = null;      	
        /// <summary>
        /// 元数据
        /// </summary>
        [Column("meta_data")]
        [DataMember(Order = 18)]
        [StringLength(2000)]
        public string MetaData { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="file"></param>        
        public virtual void CopyTo(File file)
        {
            file.Id = Id;
            file.FilePath = FilePath;
            file.Title = Title;
            file.Description = Description;
            file.Url = Url;
            file.State = State;
            file.CreatedOn = CreatedOn;
            file.Size = Size;
            file.ContentType = ContentType;
            file.StorageType = StorageType;
            file.StorageData = StorageData;
            file.UserId = UserId;
            file.CreatedBy = CreatedBy;
            file.Name = Name;
            file.ApplicationId = ApplicationId;
            file.Sn = Sn;
            file.CoverUrl = CoverUrl;
            file.MetaType = MetaType;
            file.MetaData = MetaData;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual File Clone()
        {
            var obj = new File();
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
            var sb = new System.Text.StringBuilder("File{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", FilePath='");
            sb.Append(FilePath).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", Url='");
            sb.Append(Url).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", Size='");
            sb.Append(Size).AppendLine("'");
            sb.Append(", ContentType='");
            sb.Append(ContentType).AppendLine("'");
            sb.Append(", StorageType='");
            sb.Append(StorageType).AppendLine("'");
            sb.Append(", StorageData='");
            sb.Append(StorageData).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", Sn='");
            sb.Append(Sn).AppendLine("'");
            sb.Append(", CoverUrl='");
            sb.Append(CoverUrl).AppendLine("'");
            sb.Append(", MetaType='");
            sb.Append(MetaType).AppendLine("'");
            sb.Append(", MetaData='");
            sb.Append(MetaData).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}