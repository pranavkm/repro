using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of merchant
    /// </summary>
    [Table("merchant")]
    [DataContract]
    public partial class Merchant
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Merchant"/>的构造函数
        /// </summary>
        public Merchant()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 商家Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 商家名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 商家站点
        /// </summary>
        [Column("site")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Site { get; set; } = string.Empty;      	
        /// <summary>
        /// 商家logo
        /// </summary>
        [Column("logo")]
        [DataMember(Order = 3)]
        [StringLength(200)]
        public string Logo { get; set; } = string.Empty;      	
        /// <summary>
        /// 商家类型
        /// </summary>
        [Column("merchant_type")]
        [DataMember(Order = 4)]
        public int MerchantType { get; set; } = 0;      	
        /// <summary>
        /// 验证状态
        /// </summary>
        [Column("verify_state")]
        [DataMember(Order = 5)]
        public int VerifyState { get; set; } = 0;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 6)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 客服电话
        /// </summary>
        [Column("service_tel")]
        [DataMember(Order = 7)]
        [StringLength(24)]
        public string ServiceTel { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 8)]
        public long UserId { get; set; } = (long)0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 9)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 11)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 12)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 13)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 14)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 商家标识位1=是否推荐,2=是否显示,4=是否支持返现,8=是否导流
        /// </summary>
        [Column("merchant_flags")]
        [DataMember(Order = 15)]
        public long MerchantFlags { get; set; } = 0;      	
        /// <summary>
        /// url路径名
        /// </summary>
        [Column("url_name")]
        [DataMember(Order = 16)]
        [StringLength(160)]
        public string UrlName { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="merchant"></param>        
        public virtual void CopyTo(Merchant merchant)
        {
            merchant.Id = Id;
            merchant.Name = Name;
            merchant.Site = Site;
            merchant.Logo = Logo;
            merchant.MerchantType = MerchantType;
            merchant.VerifyState = VerifyState;
            merchant.SortNo = SortNo;
            merchant.ServiceTel = ServiceTel;
            merchant.UserId = UserId;
            merchant.CreatedBy = CreatedBy;
            merchant.CreatedOn = CreatedOn;
            merchant.UpdatedBy = UpdatedBy;
            merchant.UpdatedOn = UpdatedOn;
            merchant.ApplicationId = ApplicationId;
            merchant.State = State;
            merchant.MerchantFlags = MerchantFlags;
            merchant.UrlName = UrlName;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Merchant Clone()
        {
            var obj = new Merchant();
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
            var sb = new System.Text.StringBuilder("Merchant{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Site='");
            sb.Append(Site).AppendLine("'");
            sb.Append(", Logo='");
            sb.Append(Logo).AppendLine("'");
            sb.Append(", MerchantType='");
            sb.Append(MerchantType).AppendLine("'");
            sb.Append(", VerifyState='");
            sb.Append(VerifyState).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", ServiceTel='");
            sb.Append(ServiceTel).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", MerchantFlags='");
            sb.Append(MerchantFlags).AppendLine("'");
            sb.Append(", UrlName='");
            sb.Append(UrlName).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}