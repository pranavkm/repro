using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category_merchant
    /// </summary>
    [Table("category_merchant")]
    [DataContract]
    public partial class CategoryMerchant
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CategoryMerchant"/>的构造函数
        /// </summary>
        public CategoryMerchant()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 分类Id
        /// </summary>
        [Key]
        [Column("category_id")]
        [DataMember(Order = 0)]
        public int CategoryId { get; set; } = 0;      	
        /// <summary>
        /// 商家Id
        /// </summary>
        [Key]
        [Column("merchant_id")]
        [DataMember(Order = 1)]
        public int MerchantId { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 2)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 商家有效sku数量
        /// </summary>
        [Column("sku_count")]
        [DataMember(Order = 3)]
        public int SkuCount { get; set; } = 0;      	
        /// <summary>
        /// 数据标识
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 4)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 5)]
        public long UserId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="categoryMerchant"></param>        
        public virtual void CopyTo(CategoryMerchant categoryMerchant)
        {
            categoryMerchant.CategoryId = CategoryId;
            categoryMerchant.MerchantId = MerchantId;
            categoryMerchant.SortNo = SortNo;
            categoryMerchant.SkuCount = SkuCount;
            categoryMerchant.DataFlags = DataFlags;
            categoryMerchant.UserId = UserId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CategoryMerchant Clone()
        {
            var obj = new CategoryMerchant();
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
            var sb = new System.Text.StringBuilder("CategoryMerchant{");
            sb.Append("CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", MerchantId='");
            sb.Append(MerchantId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", SkuCount='");
            sb.Append(SkuCount).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}