using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of brand_source
    /// </summary>
    [Table("brand_source")]
    [DataContract]
    public partial class BrandSource
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.BrandSource"/>的构造函数
        /// </summary>
        public BrandSource()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 品牌源Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// url地址
        /// </summary>
        [Column("url")]
        [DataMember(Order = 1)]
        [StringLength(500)]
        public string Url { get; set; } = string.Empty;      	
        /// <summary>
        /// 外部数据的Id
        /// </summary>
        [Column("unique_id")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string UniqueId { get; set; } = string.Empty;      	
        /// <summary>
        /// 添加时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 4)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 相关数据
        /// </summary>
        [Column("data")]
        [DataMember(Order = 5)]
        public string Data { get; set; } = null;      	
        /// <summary>
        /// 外部来源名(如amazon)
        /// </summary>
        [Column("source_name")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string SourceName { get; set; } = string.Empty;      	
        /// <summary>
        /// 映射的系统品牌Id
        /// </summary>
        [Column("brand_id")]
        [DataMember(Order = 7)]
        public int? BrandId { get; set; } = null;      	
        /// <summary>
        /// 状态1=有效
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 品牌所有权类型1=自有,2=第三方授权
        /// </summary>
        [Column("ownership_type")]
        [DataMember(Order = 9)]
        public int? OwnershipType { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="brandSource"></param>        
        public virtual void CopyTo(BrandSource brandSource)
        {
            brandSource.Id = Id;
            brandSource.Url = Url;
            brandSource.UniqueId = UniqueId;
            brandSource.CreatedOn = CreatedOn;
            brandSource.Name = Name;
            brandSource.Data = Data;
            brandSource.SourceName = SourceName;
            brandSource.BrandId = BrandId;
            brandSource.State = State;
            brandSource.OwnershipType = OwnershipType;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual BrandSource Clone()
        {
            var obj = new BrandSource();
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
            var sb = new System.Text.StringBuilder("BrandSource{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Url='");
            sb.Append(Url).AppendLine("'");
            sb.Append(", UniqueId='");
            sb.Append(UniqueId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Data='");
            sb.Append(Data).AppendLine("'");
            sb.Append(", SourceName='");
            sb.Append(SourceName).AppendLine("'");
            sb.Append(", BrandId='");
            sb.Append(BrandId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
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