using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of brand
    /// </summary>
    [Table("brand")]
    [DataContract]
    public partial class Brand
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Brand"/>的构造函数
        /// </summary>
        public Brand()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 品牌Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 名称 中文名+空格+(英文名)
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 2)]
        [StringLength(8000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// logo
        /// </summary>
        [Column("logo")]
        [DataMember(Order = 3)]
        [StringLength(500)]
        public string Logo { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 4)]
        public long UserId { get; set; } = 0;      	
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
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 7)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 8)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 来源Id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 9)]
        public int SourceId { get; set; } = 0;      	
        /// <summary>
        /// 英文名
        /// </summary>
        [Column("english_name")]
        [DataMember(Order = 10)]
        [StringLength(100)]
        public string EnglishName { get; set; } = string.Empty;      	
        /// <summary>
        /// 中文名
        /// </summary>
        [Column("chinese_name")]
        [DataMember(Order = 11)]
        [StringLength(100)]
        public string ChineseName { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据标识
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 12)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 13)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 14)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 15)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// url路径名
        /// </summary>
        [Column("url_name")]
        [DataMember(Order = 16)]
        [StringLength(160)]
        public string UrlName { get; set; } = string.Empty;      	
        /// <summary>
        /// 品牌所有权类型1=自有,2=第三方授权
        /// </summary>
        [Column("ownership_type")]
        [DataMember(Order = 17)]
        public int OwnershipType { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="brand"></param>        
        public virtual void CopyTo(Brand brand)
        {
            brand.Id = Id;
            brand.Name = Name;
            brand.Description = Description;
            brand.Logo = Logo;
            brand.UserId = UserId;
            brand.CreatedBy = CreatedBy;
            brand.CreatedOn = CreatedOn;
            brand.State = State;
            brand.ApplicationId = ApplicationId;
            brand.SourceId = SourceId;
            brand.EnglishName = EnglishName;
            brand.ChineseName = ChineseName;
            brand.DataFlags = DataFlags;
            brand.SortNo = SortNo;
            brand.UpdatedBy = UpdatedBy;
            brand.UpdatedOn = UpdatedOn;
            brand.UrlName = UrlName;
            brand.OwnershipType = OwnershipType;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Brand Clone()
        {
            var obj = new Brand();
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
            var sb = new System.Text.StringBuilder("Brand{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", Logo='");
            sb.Append(Logo).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append(", EnglishName='");
            sb.Append(EnglishName).AppendLine("'");
            sb.Append(", ChineseName='");
            sb.Append(ChineseName).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", UrlName='");
            sb.Append(UrlName).AppendLine("'");
            sb.Append(", OwnershipType='");
            sb.Append(OwnershipType).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}