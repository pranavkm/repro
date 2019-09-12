using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of merchant_brand
    /// </summary>
    [Table("merchant_brand")]
    [DataContract]
    public partial class MerchantBrand
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.MerchantBrand"/>的构造函数
        /// </summary>
        public MerchantBrand()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 商家Id
        /// </summary>
        [Key]
        [Column("merchant_id")]
        [DataMember(Order = 0)]
        public int MerchantId { get; set; } = 0;      	
        /// <summary>
        /// 品牌Id
        /// </summary>
        [Key]
        [Column("brand_id")]
        [DataMember(Order = 1)]
        public int BrandId { get; set; } = 0;      	
        /// <summary>
        /// 品牌所有权类型1=自有,2=第三方授权
        /// </summary>
        [Column("ownership_type")]
        [DataMember(Order = 2)]
        public int OwnershipType { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 3)]
        public int State { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="merchantBrand"></param>        
        public virtual void CopyTo(MerchantBrand merchantBrand)
        {
            merchantBrand.MerchantId = MerchantId;
            merchantBrand.BrandId = BrandId;
            merchantBrand.OwnershipType = OwnershipType;
            merchantBrand.State = State;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual MerchantBrand Clone()
        {
            var obj = new MerchantBrand();
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
            var sb = new System.Text.StringBuilder("MerchantBrand{");
            sb.Append("MerchantId='");
            sb.Append(MerchantId).AppendLine("'");
            sb.Append(", BrandId='");
            sb.Append(BrandId).AppendLine("'");
            sb.Append(", OwnershipType='");
            sb.Append(OwnershipType).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}