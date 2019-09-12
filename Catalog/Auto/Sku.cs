using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of sku
    /// </summary>
    [Table("sku")]
    [DataContract]
    public partial class Sku
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Sku"/>的构造函数
        /// </summary>
        public Sku()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        ///
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 商品id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 销售价格
        /// </summary>
        [Column("price")]
        [DataMember(Order = 3)]
        public decimal Price { get; set; } = 0.0m;      	
        /// <summary>
        /// 库存状态
        /// </summary>
        [Column("stock_state")]
        [DataMember(Order = 4)]
        public int StockState { get; set; } = 0;      	
        /// <summary>
        /// 库存备注
        /// </summary>
        [Column("stock_remark")]
        [DataMember(Order = 5)]
        [StringLength(500)]
        public string StockRemark { get; set; } = string.Empty;      	
        /// <summary>
        /// 库存数量
        /// </summary>
        [Column("stock_quantity")]
        [DataMember(Order = 6)]
        public decimal StockQuantity { get; set; } = 0.0m;      	
        /// <summary>
        /// 条形码.UPC码,SN码,PLU码统称为条形码
        /// </summary>
        [Column("bar_code")]
        [DataMember(Order = 7)]
        [StringLength(128)]
        public string BarCode { get; set; } = null;      	
        /// <summary>
        /// 外部ID,系统不保证唯一性
        /// </summary>
        [Column("outer_id")]
        [DataMember(Order = 8)]
        [StringLength(128)]
        public string OuterId { get; set; } = null;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 9)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 来源id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 10)]
        public long SourceId { get; set; } = 0;      	
        /// <summary>
        /// 所属商家id
        /// </summary>
        [Column("merchant_id")]
        [DataMember(Order = 11)]
        public int MerchantId { get; set; } = 0;      	
        /// <summary>
        /// 供应商id
        /// </summary>
        [Column("vendor_id")]
        [DataMember(Order = 12)]
        public int VendorId { get; set; } = 0;      	
        /// <summary>
        /// 销售数量
        /// </summary>
        [Column("sold_quantity")]
        [DataMember(Order = 13)]
        public decimal SoldQuantity { get; set; } = 0.0m;      	
        /// <summary>
        /// SKU上架时间
        /// </summary>
        [Column("listing_time")]
        [DataMember(Order = 14)]
        public DateTimeOffset? ListingTime { get; set; } = null;      	
        /// <summary>
        /// 货币单位,如:USD,CNY
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 15)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 16)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 17)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// vip会员价
        /// </summary>
        [Column("vip_price")]
        [DataMember(Order = 18)]
        public decimal? VipPrice { get; set; } = null;      	
        /// <summary>
        /// 原价/市场价
        /// </summary>
        [Column("original_price")]
        [DataMember(Order = 19)]
        public decimal? OriginalPrice { get; set; } = null;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 20)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 21)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 应用id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 22)]
        public int ApplicationId { get; set; } = (int)0;      	
        /// <summary>
        /// sku编号
        /// </summary>
        [Column("sn")]
        [DataMember(Order = 23)]
        [StringLength(64)]
        public string Sn { get; set; } = string.Empty;      	
        /// <summary>
        /// 所属用户id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 24)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 租户id
        /// </summary>
        [Column("tenant_id")]
        [DataMember(Order = 25)]
        public int TenantId { get; set; } = 0;      	
        /// <summary>
        /// 分类id
        /// </summary>
        [Column("category_id")]
        [DataMember(Order = 26)]
        public int CategoryId { get; set; } = 0;      	
        /// <summary>
        /// 每个sku包括的服务/商品数量
        /// </summary>
        [Column("unit_quantity")]
        [DataMember(Order = 27)]
        public decimal UnitQuantity { get; set; } = 1.000000m;      	
        /// <summary>
        /// 成本价/进货价
        /// </summary>
        [Column("cost_price")]
        [DataMember(Order = 28)]
        public decimal? CostPrice { get; set; } = null;      	
        /// <summary>
        /// 起购量
        /// </summary>
        [Column("min_limits")]
        [DataMember(Order = 29)]
        public decimal MinLimits { get; set; } = 1.000000m;      	
        /// <summary>
        /// 最大购买量
        /// </summary>
        [Column("max_limits")]
        [DataMember(Order = 30)]
        public decimal? MaxLimits { get; set; } = null;      	
        /// <summary>
        /// 销售状态1=现货,2=补货,3=预售
        /// </summary>
        [Column("sale_state")]
        [DataMember(Order = 31)]
        public int SaleState { get; set; } = 0;      	
        /// <summary>
        /// 上架状态0=待定,1=上架,2=下架
        /// </summary>
        [Column("list_state")]
        [DataMember(Order = 32)]
        public int ListState { get; set; } = 0;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 33)]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;      	
        /// <summary>
        /// 仓库id
        /// </summary>
        [Column("warehouse_id")]
        [DataMember(Order = 34)]
        public int WarehouseId { get; set; } = 0;      	
        /// <summary>
        /// 佣金比例(百分比)
        /// </summary>
        [Column("commission_rate")]
        [DataMember(Order = 35)]
        public decimal? CommissionRate { get; set; } = 0.00m;      	
        /// <summary>
        /// 品牌Id
        /// </summary>
        [Column("brand_id")]
        [DataMember(Order = 36)]
        public int BrandId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="sku"></param>        
        public virtual void CopyTo(Sku sku)
        {
            sku.Id = Id;
            sku.ItemId = ItemId;
            sku.Name = Name;
            sku.Price = Price;
            sku.StockState = StockState;
            sku.StockRemark = StockRemark;
            sku.StockQuantity = StockQuantity;
            sku.BarCode = BarCode;
            sku.OuterId = OuterId;
            sku.State = State;
            sku.SourceId = SourceId;
            sku.MerchantId = MerchantId;
            sku.VendorId = VendorId;
            sku.SoldQuantity = SoldQuantity;
            sku.ListingTime = ListingTime;
            sku.Currency = Currency;
            sku.UpdatedOn = UpdatedOn;
            sku.CreatedOn = CreatedOn;
            sku.VipPrice = VipPrice;
            sku.OriginalPrice = OriginalPrice;
            sku.CreatedBy = CreatedBy;
            sku.UpdatedBy = UpdatedBy;
            sku.ApplicationId = ApplicationId;
            sku.Sn = Sn;
            sku.UserId = UserId;
            sku.TenantId = TenantId;
            sku.CategoryId = CategoryId;
            sku.UnitQuantity = UnitQuantity;
            sku.CostPrice = CostPrice;
            sku.MinLimits = MinLimits;
            sku.MaxLimits = MaxLimits;
            sku.SaleState = SaleState;
            sku.ListState = ListState;
            sku.Title = Title;
            sku.WarehouseId = WarehouseId;
            sku.CommissionRate = CommissionRate;
            sku.BrandId = BrandId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Sku Clone()
        {
            var obj = new Sku();
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
            var sb = new System.Text.StringBuilder("Sku{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Price='");
            sb.Append(Price).AppendLine("'");
            sb.Append(", StockState='");
            sb.Append(StockState).AppendLine("'");
            sb.Append(", StockRemark='");
            sb.Append(StockRemark).AppendLine("'");
            sb.Append(", StockQuantity='");
            sb.Append(StockQuantity).AppendLine("'");
            sb.Append(", BarCode='");
            sb.Append(BarCode).AppendLine("'");
            sb.Append(", OuterId='");
            sb.Append(OuterId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append(", MerchantId='");
            sb.Append(MerchantId).AppendLine("'");
            sb.Append(", VendorId='");
            sb.Append(VendorId).AppendLine("'");
            sb.Append(", SoldQuantity='");
            sb.Append(SoldQuantity).AppendLine("'");
            sb.Append(", ListingTime='");
            sb.Append(ListingTime).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", VipPrice='");
            sb.Append(VipPrice).AppendLine("'");
            sb.Append(", OriginalPrice='");
            sb.Append(OriginalPrice).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", Sn='");
            sb.Append(Sn).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", TenantId='");
            sb.Append(TenantId).AppendLine("'");
            sb.Append(", CategoryId='");
            sb.Append(CategoryId).AppendLine("'");
            sb.Append(", UnitQuantity='");
            sb.Append(UnitQuantity).AppendLine("'");
            sb.Append(", CostPrice='");
            sb.Append(CostPrice).AppendLine("'");
            sb.Append(", MinLimits='");
            sb.Append(MinLimits).AppendLine("'");
            sb.Append(", MaxLimits='");
            sb.Append(MaxLimits).AppendLine("'");
            sb.Append(", SaleState='");
            sb.Append(SaleState).AppendLine("'");
            sb.Append(", ListState='");
            sb.Append(ListState).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", WarehouseId='");
            sb.Append(WarehouseId).AppendLine("'");
            sb.Append(", CommissionRate='");
            sb.Append(CommissionRate).AppendLine("'");
            sb.Append(", BrandId='");
            sb.Append(BrandId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}