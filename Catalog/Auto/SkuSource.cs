using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of sku_source
    /// </summary>
    [Table("sku_source")]
    [DataContract]
    public partial class SkuSource
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.SkuSource"/>的构造函数
        /// </summary>
        public SkuSource()
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
        /// 外部源Id
        /// </summary>
        [Column("unique_id")]
        [DataMember(Order = 1)]
        [StringLength(200)]
        public string UniqueId { get; set; } = string.Empty;      	
        /// <summary>
        /// 源url
        /// </summary>
        [Column("url")]
        [DataMember(Order = 2)]
        [StringLength(1000)]
        public string Url { get; set; } = string.Empty;      	
        /// <summary>
        /// 源分类Id
        /// </summary>
        [Column("category_source_id")]
        [DataMember(Order = 3)]
        public int CategorySourceId { get; set; } = 0;      	
        /// <summary>
        /// 源品牌Id
        /// </summary>
        [Column("brand_source_id")]
        [DataMember(Order = 4)]
        public int BrandSourceId { get; set; } = 0;      	
        /// <summary>
        /// 源分类名
        /// </summary>
        [Column("category_name")]
        [DataMember(Order = 5)]
        [StringLength(100)]
        public string CategoryName { get; set; } = null;      	
        /// <summary>
        /// 源品牌名
        /// </summary>
        [Column("brand_name")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string BrandName { get; set; } = null;      	
        /// <summary>
        /// 源型号名
        /// </summary>
        [Column("model_name")]
        [DataMember(Order = 7)]
        [StringLength(100)]
        public string ModelName { get; set; } = null;      	
        /// <summary>
        /// 外部来源名(如amazon)
        /// </summary>
        [Column("source_name")]
        [DataMember(Order = 8)]
        [StringLength(100)]
        public string SourceName { get; set; } = string.Empty;      	
        /// <summary>
        /// 添加时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 10)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 商家Id
        /// </summary>
        [Column("merchant_id")]
        [DataMember(Order = 11)]
        public int MerchantId { get; set; } = 0;      	
        /// <summary>
        /// SkuId
        /// </summary>
        [Column("sku_id")]
        [DataMember(Order = 12)]
        public long SkuId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="skuSource"></param>        
        public virtual void CopyTo(SkuSource skuSource)
        {
            skuSource.Id = Id;
            skuSource.UniqueId = UniqueId;
            skuSource.Url = Url;
            skuSource.CategorySourceId = CategorySourceId;
            skuSource.BrandSourceId = BrandSourceId;
            skuSource.CategoryName = CategoryName;
            skuSource.BrandName = BrandName;
            skuSource.ModelName = ModelName;
            skuSource.SourceName = SourceName;
            skuSource.CreatedOn = CreatedOn;
            skuSource.State = State;
            skuSource.MerchantId = MerchantId;
            skuSource.SkuId = SkuId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual SkuSource Clone()
        {
            var obj = new SkuSource();
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
            var sb = new System.Text.StringBuilder("SkuSource{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", UniqueId='");
            sb.Append(UniqueId).AppendLine("'");
            sb.Append(", Url='");
            sb.Append(Url).AppendLine("'");
            sb.Append(", CategorySourceId='");
            sb.Append(CategorySourceId).AppendLine("'");
            sb.Append(", BrandSourceId='");
            sb.Append(BrandSourceId).AppendLine("'");
            sb.Append(", CategoryName='");
            sb.Append(CategoryName).AppendLine("'");
            sb.Append(", BrandName='");
            sb.Append(BrandName).AppendLine("'");
            sb.Append(", ModelName='");
            sb.Append(ModelName).AppendLine("'");
            sb.Append(", SourceName='");
            sb.Append(SourceName).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", MerchantId='");
            sb.Append(MerchantId).AppendLine("'");
            sb.Append(", SkuId='");
            sb.Append(SkuId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}