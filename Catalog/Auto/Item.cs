using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item
    /// </summary>
    [Table("item")]
    [DataContract]
    public partial class Item
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Item"/>的构造函数
        /// </summary>
        public Item()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 信息Id
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 1)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 分类Id
        /// </summary>
        [Column("category_id")]
        [DataMember(Order = 2)]
        public int CategoryId { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 3)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 4)]
        [StringLength(500)]
        public string Title { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 5)]
        public long UserId { get; set; } = (long)0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 6)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 7)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 8)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 发布时间
        /// </summary>
        [Column("publish_time")]
        [DataMember(Order = 10)]
        public DateTimeOffset PublishTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// url路径名
        /// </summary>
        [Column("url_name")]
        [DataMember(Order = 11)]
        [StringLength(160)]
        public string UrlName { get; set; } = null;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 12)]
        public int SortNo { get; set; } = (int)0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 13)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 审核状态
        /// </summary>
        [Column("audit_state")]
        [DataMember(Order = 14)]
        public int AuditState { get; set; } = 0;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 15)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 来源Id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 16)]
        public long SourceId { get; set; } = (long)0;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 17)]
        [StringLength(12000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 租户Id
        /// </summary>
        [Column("tenant_id")]
        [DataMember(Order = 18)]
        public int TenantId { get; set; } = (int)0;      	
        /// <summary>
        /// 开始时间/上市日期
        /// </summary>
        [Column("begin_time")]
        [DataMember(Order = 19)]
        public DateTimeOffset? BeginTime { get; set; } = null;      	
        /// <summary>
        /// 结束时间
        /// </summary>
        [Column("end_time")]
        [DataMember(Order = 20)]
        public DateTimeOffset? EndTime { get; set; } = null;      	
        /// <summary>
        /// 应用客户端id,如一个网站app,手机app
        /// </summary>
        [Column("client_id")]
        [DataMember(Order = 21)]
        [StringLength(128)]
        public string ClientId { get; set; } = null;      	
        /// <summary>
        /// 上级Id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 22)]
        public long ParentId { get; set; } = (long)0;      	
        /// <summary>
        /// 根信息Id,应用自定义使用方式
        /// </summary>
        [Column("root_id")]
        [DataMember(Order = 23)]
        public long RootId { get; set; } = (long)0;      	
        /// <summary>
        /// 顶级信息Id
        /// </summary>
        [Column("top_id")]
        [DataMember(Order = 24)]
        public long TopId { get; set; } = (long)0;      	
        /// <summary>
        /// 商家Id
        /// </summary>
        [Column("merchant_id")]
        [DataMember(Order = 25)]
        public int MerchantId { get; set; } = (int)0;      	
        /// <summary>
        /// 店铺/供应商Id
        /// </summary>
        [Column("vendor_id")]
        [DataMember(Order = 26)]
        public int VendorId { get; set; } = (int)0;      	
        /// <summary>
        /// 上级Id路径
        /// </summary>
        [Column("parent_path")]
        [DataMember(Order = 27)]
        [StringLength(200)]
        public string ParentPath { get; set; } = string.Empty;      	
        /// <summary>
        /// 品牌Id
        /// </summary>
        [Column("brand_id")]
        [DataMember(Order = 28)]
        public int BrandId { get; set; } = (int)0;      	
        /// <summary>
        /// 地区Id
        /// </summary>
        [Column("region_id")]
        [DataMember(Order = 29)]
        public int RegionId { get; set; } = (int)0;      	
        /// <summary>
        /// 经度
        /// </summary>
        [Column("longitude")]
        [DataMember(Order = 30)]
        public double? Longitude { get; set; } = null;      	
        /// <summary>
        /// 纬度
        /// </summary>
        [Column("latitude")]
        [DataMember(Order = 31)]
        public double? Latitude { get; set; } = null;      	
        /// <summary>
        /// 管理用户id
        /// </summary>
        [Column("manage_by")]
        [DataMember(Order = 32)]
        public long ManageBy { get; set; } = (long)0;      	
        /// <summary>
        /// 销售价格
        /// </summary>
        [Column("price")]
        [DataMember(Order = 33)]
        public decimal? Price { get; set; } = null;      	
        /// <summary>
        /// 原价
        /// </summary>
        [Column("original_price")]
        [DataMember(Order = 34)]
        public decimal? OriginalPrice { get; set; } = null;      	
        /// <summary>
        /// 货币单位，如：USD,CNY
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 35)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// 编号/编码
        /// </summary>
        [Column("sn")]
        [DataMember(Order = 36)]
        [StringLength(128)]
        public string Sn { get; set; } = string.Empty;      	
        /// <summary>
        /// 成本价/进货价
        /// </summary>
        [Column("cost_price")]
        [DataMember(Order = 37)]
        public decimal? CostPrice { get; set; } = null;      	
        /// <summary>
        /// 副标题
        /// </summary>
        [Column("subtitle")]
        [DataMember(Order = 38)]
        [StringLength(200)]
        public string Subtitle { get; set; } = null;      	
        /// <summary>
        /// 创作者名
        /// </summary>
        [Column("creator")]
        [DataMember(Order = 39)]
        [StringLength(100)]
        public string Creator { get; set; } = null;      	
        /// <summary>
        /// 创作申明1=原创,2=摘编,3=转载
        /// </summary>
        [Column("create_mode")]
        [DataMember(Order = 40)]
        public int CreateMode { get; set; } = 0;      	
        /// <summary>
        /// 媒体类型1=视频,2=音频,3=图文
        /// </summary>
        [Column("media_type")]
        [DataMember(Order = 41)]
        public int MediaType { get; set; } = 0;      	
        /// <summary>
        /// 来源Ip
        /// </summary>
        [Column("from_ip")]
        [DataMember(Order = 42)]
        [StringLength(64)]
        public string FromIp { get; set; } = string.Empty;      	
        /// <summary>
        /// 销售状态
        /// </summary>
        [Column("sale_state")]
        [DataMember(Order = 43)]
        public int SaleState { get; set; } = 0;      	
        /// <summary>
        /// 业务标识位0=未知,1=评测,2=电商
        /// </summary>
        [Column("business_flags")]
        [DataMember(Order = 44)]
        public long BusinessFlags { get; set; } = (long)0;      	
        /// <summary>
        /// 工厂价
        /// </summary>
        [Column("factory_price")]
        [DataMember(Order = 45)]
        public decimal FactoryPrice { get; set; } = 0.0m;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="item"></param>        
        public virtual void CopyTo(Item item)
        {
            item.Id = Id;
            item.ApplicationId = ApplicationId;
            item.CategoryId = CategoryId;
            item.Name = Name;
            item.Title = Title;
            item.UserId = UserId;
            item.CreatedBy = CreatedBy;
            item.UpdatedBy = UpdatedBy;
            item.CreatedOn = CreatedOn;
            item.UpdatedOn = UpdatedOn;
            item.PublishTime = PublishTime;
            item.UrlName = UrlName;
            item.SortNo = SortNo;
            item.State = State;
            item.AuditState = AuditState;
            item.DataFlags = DataFlags;
            item.SourceId = SourceId;
            item.Description = Description;
            item.TenantId = TenantId;
            item.BeginTime = BeginTime;
            item.EndTime = EndTime;
            item.ClientId = ClientId;
            item.ParentId = ParentId;
            item.RootId = RootId;
            item.TopId = TopId;
            item.MerchantId = MerchantId;
            item.VendorId = VendorId;
            item.ParentPath = ParentPath;
            item.BrandId = BrandId;
            item.RegionId = RegionId;
            item.Longitude = Longitude;
            item.Latitude = Latitude;
            item.ManageBy = ManageBy;
            item.Price = Price;
            item.OriginalPrice = OriginalPrice;
            item.Currency = Currency;
            item.Sn = Sn;
            item.CostPrice = CostPrice;
            item.Subtitle = Subtitle;
            item.Creator = Creator;
            item.CreateMode = CreateMode;
            item.MediaType = MediaType;
            item.FromIp = FromIp;
            item.SaleState = SaleState;
            item.BusinessFlags = BusinessFlags;
            item.FactoryPrice = FactoryPrice;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Item Clone()
        {
            var obj = new Item();
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
            var sb = new System.Text.StringBuilder("Item{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", PublishTime='");
            sb.Append(PublishTime).AppendLine("'");
            sb.Append(", UrlName='");
            sb.Append(UrlName).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", AuditState='");
            sb.Append(AuditState).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", TenantId='");
            sb.Append(TenantId).AppendLine("'");
            sb.Append(", BeginTime='");
            sb.Append(BeginTime).AppendLine("'");
            sb.Append(", EndTime='");
            sb.Append(EndTime).AppendLine("'");
            sb.Append(", ClientId='");
            sb.Append(ClientId).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", RootId='");
            sb.Append(RootId).AppendLine("'");
            sb.Append(", TopId='");
            sb.Append(TopId).AppendLine("'");
            sb.Append(", MerchantId='");
            sb.Append(MerchantId).AppendLine("'");
            sb.Append(", VendorId='");
            sb.Append(VendorId).AppendLine("'");
            sb.Append(", ParentPath='");
            sb.Append(ParentPath).AppendLine("'");
            sb.Append(", BrandId='");
            sb.Append(BrandId).AppendLine("'");
            sb.Append(", RegionId='");
            sb.Append(RegionId).AppendLine("'");
            sb.Append(", Longitude='");
            sb.Append(Longitude).AppendLine("'");
            sb.Append(", Latitude='");
            sb.Append(Latitude).AppendLine("'");
            sb.Append(", ManageBy='");
            sb.Append(ManageBy).AppendLine("'");
            sb.Append(", Price='");
            sb.Append(Price).AppendLine("'");
            sb.Append(", OriginalPrice='");
            sb.Append(OriginalPrice).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", Sn='");
            sb.Append(Sn).AppendLine("'");
            sb.Append(", CostPrice='");
            sb.Append(CostPrice).AppendLine("'");
            sb.Append(", Subtitle='");
            sb.Append(Subtitle).AppendLine("'");
            sb.Append(", Creator='");
            sb.Append(Creator).AppendLine("'");
            sb.Append(", CreateMode='");
            sb.Append(CreateMode).AppendLine("'");
            sb.Append(", MediaType='");
            sb.Append(MediaType).AppendLine("'");
            sb.Append(", FromIp='");
            sb.Append(FromIp).AppendLine("'");
            sb.Append(", SaleState='");
            sb.Append(SaleState).AppendLine("'");
            sb.Append(", BusinessFlags='");
            sb.Append(BusinessFlags).AppendLine("'");
            sb.Append(", FactoryPrice='");
            sb.Append(FactoryPrice).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}