using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category_brand
    /// </summary>
    [Table("category_brand")]
    [DataContract]
    public partial class CategoryBrand
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CategoryBrand"/>的构造函数
        /// </summary>
        public CategoryBrand()
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
        /// 品牌Id
        /// </summary>
        [Key]
        [Column("brand_id")]
        [DataMember(Order = 1)]
        public int BrandId { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 2)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 3)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 4)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 数据标识
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 5)]
        public long DataFlags { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="categoryBrand"></param>        
        public virtual void CopyTo(CategoryBrand categoryBrand)
        {
            categoryBrand.CategoryId = CategoryId;
            categoryBrand.BrandId = BrandId;
            categoryBrand.SortNo = SortNo;
            categoryBrand.State = State;
            categoryBrand.UserId = UserId;
            categoryBrand.DataFlags = DataFlags;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CategoryBrand Clone()
        {
            var obj = new CategoryBrand();
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
            var sb = new System.Text.StringBuilder("CategoryBrand{");
            sb.Append("CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", BrandId='");
            sb.Append(BrandId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}