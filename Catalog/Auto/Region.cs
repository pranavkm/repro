using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of region
    /// </summary>
    [Table("region")]
    [DataContract]
    public partial class Region
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Region"/>的构造函数
        /// </summary>
        public Region()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 地区id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 地区编码(唯一)
        /// </summary>
        [Column("code")]
        [DataMember(Order = 1)]
        [StringLength(128)]
        public string Code { get; set; } = null;      	
        /// <summary>
        /// 上级地区Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 2)]
        public int ParentId { get; set; } = (int)0;      	
        /// <summary>
        /// 地区id路径
        /// </summary>
        [Column("parent_path")]
        [DataMember(Order = 3)]
        [StringLength(128)]
        public string ParentPath { get; set; } = string.Empty;      	
        /// <summary>
        /// 地区类型1=国家,2=省,3=城市,4=区县,5=小区/街道,99=城市圈(大区)
        /// </summary>
        [Column("region_type")]
        [DataMember(Order = 4)]
        public int RegionType { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 5)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// url名称
        /// </summary>
        [Column("url_name")]
        [DataMember(Order = 6)]
        [StringLength(160)]
        public string UrlName { get; set; } = string.Empty;      	
        /// <summary>
        /// 简称
        /// </summary>
        [Column("short_name")]
        [DataMember(Order = 7)]
        [StringLength(50)]
        public string ShortName { get; set; } = string.Empty;      	
        /// <summary>
        /// 简拼
        /// </summary>
        [Column("acronym")]
        [DataMember(Order = 8)]
        [StringLength(50)]
        public string Acronym { get; set; } = string.Empty;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 9)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 10)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 地区所属层级
        /// </summary>
        [Column("level")]
        [DataMember(Order = 11)]
        public int Level { get; set; } = 0;      	
        /// <summary>
        /// 经度
        /// </summary>
        [Column("longitude")]
        [DataMember(Order = 12)]
        public double? Longitude { get; set; } = null;      	
        /// <summary>
        /// 纬度
        /// </summary>
        [Column("latitude")]
        [DataMember(Order = 13)]
        public double? Latitude { get; set; } = null;      	
        /// <summary>
        /// 全称
        /// </summary>
        [Column("full_name")]
        [DataMember(Order = 14)]
        [StringLength(200)]
        public string FullName { get; set; } = string.Empty;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 15)]
        [StringLength(8000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 16)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 17)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 18)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 19)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 合并的短名称
        /// </summary>
        [Column("short_full_name")]
        [DataMember(Order = 20)]
        [StringLength(200)]
        public string ShortFullName { get; set; } = null;      	
        /// <summary>
        /// 拼音
        /// </summary>
        [Column("spelling")]
        [DataMember(Order = 21)]
        [StringLength(200)]
        public string Spelling { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="region"></param>        
        public virtual void CopyTo(Region region)
        {
            region.Id = Id;
            region.Code = Code;
            region.ParentId = ParentId;
            region.ParentPath = ParentPath;
            region.RegionType = RegionType;
            region.Name = Name;
            region.UrlName = UrlName;
            region.ShortName = ShortName;
            region.Acronym = Acronym;
            region.SortNo = SortNo;
            region.State = State;
            region.Level = Level;
            region.Longitude = Longitude;
            region.Latitude = Latitude;
            region.FullName = FullName;
            region.Description = Description;
            region.UserId = UserId;
            region.DataFlags = DataFlags;
            region.CreatedOn = CreatedOn;
            region.UpdatedOn = UpdatedOn;
            region.ShortFullName = ShortFullName;
            region.Spelling = Spelling;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Region Clone()
        {
            var obj = new Region();
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
            var sb = new System.Text.StringBuilder("Region{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", ParentPath='");
            sb.Append(ParentPath).AppendLine("'");
            sb.Append(", RegionType='");
            sb.Append(RegionType).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", UrlName='");
            sb.Append(UrlName).AppendLine("'");
            sb.Append(", ShortName='");
            sb.Append(ShortName).AppendLine("'");
            sb.Append(", Acronym='");
            sb.Append(Acronym).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", Level='");
            sb.Append(Level).AppendLine("'");
            sb.Append(", Longitude='");
            sb.Append(Longitude).AppendLine("'");
            sb.Append(", Latitude='");
            sb.Append(Latitude).AppendLine("'");
            sb.Append(", FullName='");
            sb.Append(FullName).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", ShortFullName='");
            sb.Append(ShortFullName).AppendLine("'");
            sb.Append(", Spelling='");
            sb.Append(Spelling).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}