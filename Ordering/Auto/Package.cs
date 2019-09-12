using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of package
    /// </summary>
    [Table("package")]
    [DataContract]
    public partial class Package
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Package"/>的构造函数
        /// </summary>
        public Package()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 系统包裹Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 快递单号
        /// </summary>
        [Column("package_no")]
        [DataMember(Order = 1)]
        [StringLength(50)]
        public string PackageNo { get; set; } = string.Empty;      	
        /// <summary>
        /// 快递公司Id
        /// </summary>
        [Column("express_id")]
        [DataMember(Order = 2)]
        public int ExpressId { get; set; } = 0;      	
        /// <summary>
        /// 快递公司名称
        /// </summary>
        [Column("express_name")]
        [DataMember(Order = 3)]
        [StringLength(100)]
        public string ExpressName { get; set; } = string.Empty;      	
        /// <summary>
        /// 国家Id
        /// </summary>
        [Column("country_id")]
        [DataMember(Order = 4)]
        public int CountryId { get; set; } = 0;      	
        /// <summary>
        /// 国家名
        /// </summary>
        [Column("country")]
        [DataMember(Order = 5)]
        [StringLength(50)]
        public string Country { get; set; } = string.Empty;      	
        /// <summary>
        /// 省Id
        /// </summary>
        [Column("province_id")]
        [DataMember(Order = 6)]
        public int ProvinceId { get; set; } = 0;      	
        /// <summary>
        /// 省名
        /// </summary>
        [Column("province")]
        [DataMember(Order = 7)]
        [StringLength(50)]
        public string Province { get; set; } = string.Empty;      	
        /// <summary>
        /// 城市Id
        /// </summary>
        [Column("city_id")]
        [DataMember(Order = 8)]
        public int CityId { get; set; } = 0;      	
        /// <summary>
        /// 城市名
        /// </summary>
        [Column("city")]
        [DataMember(Order = 9)]
        [StringLength(50)]
        public string City { get; set; } = string.Empty;      	
        /// <summary>
        /// 区县Id
        /// </summary>
        [Column("district_id")]
        [DataMember(Order = 10)]
        public int DistrictId { get; set; } = 0;      	
        /// <summary>
        /// 区县名
        /// </summary>
        [Column("district")]
        [DataMember(Order = 11)]
        [StringLength(50)]
        public string District { get; set; } = string.Empty;      	
        /// <summary>
        /// 邮编
        /// </summary>
        [Column("zip_code")]
        [DataMember(Order = 12)]
        [StringLength(10)]
        public string ZipCode { get; set; } = string.Empty;      	
        /// <summary>
        /// 街道
        /// </summary>
        [Column("street")]
        [DataMember(Order = 13)]
        [StringLength(50)]
        public string Street { get; set; } = string.Empty;      	
        /// <summary>
        /// 街道Id，默认为0
        /// </summary>
        [Column("street_id")]
        [DataMember(Order = 14)]
        public int StreetId { get; set; } = (int)0;      	
        /// <summary>
        /// 详细地址
        /// </summary>
        [Column("address")]
        [DataMember(Order = 15)]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;      	
        /// <summary>
        /// 收件人
        /// </summary>
        [Column("consignee")]
        [DataMember(Order = 16)]
        [StringLength(30)]
        public string Consignee { get; set; } = string.Empty;      	
        /// <summary>
        /// 收件人地址Id（初始）
        /// </summary>
        [Column("consignee_id")]
        [DataMember(Order = 17)]
        public long ConsigneeId { get; set; } = 0;      	
        /// <summary>
        /// 手机
        /// </summary>
        [Column("mobile")]
        [DataMember(Order = 18)]
        [StringLength(20)]
        public string Mobile { get; set; } = string.Empty;      	
        /// <summary>
        /// 电话
        /// </summary>
        [Column("phone")]
        [DataMember(Order = 19)]
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;      	
        /// <summary>
        /// 邮箱
        /// </summary>
        [Column("email")]
        [DataMember(Order = 20)]
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;      	
        /// <summary>
        /// 是否要求确认收货
        /// </summary>
        [Column("confirm_required")]
        [DataMember(Order = 21)]
        public bool ConfirmRequired { get; set; } = false;      	
        /// <summary>
        /// 打包用户（运营端）
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 22)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 打包时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 23)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 包裹状态:0=等待打包;1=已打包;2=等待取件;3=已取件;4=在途配送;5=等待签收;6=已经签收;10001=已被拒收;10002=退回在途;10003=包裹退回;10004=重新入库
        /// </summary>
        [Column("delivery_state")]
        [DataMember(Order = 24)]
        public int DeliveryState { get; set; } = 0;      	
        /// <summary>
        /// 包括物品描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 25)]
        [StringLength(100)]
        public string Description { get; set; } = null;      	
        /// <summary>
        /// 包括物品件数
        /// </summary>
        [Column("items_count")]
        [DataMember(Order = 26)]
        public int? ItemsCount { get; set; } = null;      	
        /// <summary>
        /// 本条数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 27)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 送货时间段
        /// </summary>
        [Column("delivery_period")]
        [DataMember(Order = 28)]
        [StringLength(200)]
        public string DeliveryPeriod { get; set; } = string.Empty;      	
        /// <summary>
        /// 包裹重量
        /// </summary>
        [Column("weight")]
        [DataMember(Order = 29)]
        public decimal? Weight { get; set; } = null;      	
        /// <summary>
        /// 送货日期
        /// </summary>
        [Column("delivery_date")]
        [DataMember(Order = 30)]
        public DateTimeOffset? DeliveryDate { get; set; } = null;      	
        /// <summary>
        /// 发货日期
        /// </summary>
        [Column("shipped_date")]
        [DataMember(Order = 31)]
        public DateTimeOffset? ShippedDate { get; set; } = null;      	
        /// <summary>
        /// 包裹所属用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 32)]
        public long UserId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="package"></param>        
        public virtual void CopyTo(Package package)
        {
            package.Id = Id;
            package.PackageNo = PackageNo;
            package.ExpressId = ExpressId;
            package.ExpressName = ExpressName;
            package.CountryId = CountryId;
            package.Country = Country;
            package.ProvinceId = ProvinceId;
            package.Province = Province;
            package.CityId = CityId;
            package.City = City;
            package.DistrictId = DistrictId;
            package.District = District;
            package.ZipCode = ZipCode;
            package.Street = Street;
            package.StreetId = StreetId;
            package.Address = Address;
            package.Consignee = Consignee;
            package.ConsigneeId = ConsigneeId;
            package.Mobile = Mobile;
            package.Phone = Phone;
            package.Email = Email;
            package.ConfirmRequired = ConfirmRequired;
            package.CreatedBy = CreatedBy;
            package.CreatedOn = CreatedOn;
            package.DeliveryState = DeliveryState;
            package.Description = Description;
            package.ItemsCount = ItemsCount;
            package.State = State;
            package.DeliveryPeriod = DeliveryPeriod;
            package.Weight = Weight;
            package.DeliveryDate = DeliveryDate;
            package.ShippedDate = ShippedDate;
            package.UserId = UserId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Package Clone()
        {
            var obj = new Package();
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
            var sb = new System.Text.StringBuilder("Package{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", PackageNo='");
            sb.Append(PackageNo).AppendLine("'");
            sb.Append(", ExpressId='");
            sb.Append(ExpressId).AppendLine("'");
            sb.Append(", ExpressName='");
            sb.Append(ExpressName).AppendLine("'");
            sb.Append(", CountryId='");
            sb.Append(CountryId).AppendLine("'");
            sb.Append(", Country='");
            sb.Append(Country).AppendLine("'");
            sb.Append(", ProvinceId='");
            sb.Append(ProvinceId).AppendLine("'");
            sb.Append(", Province='");
            sb.Append(Province).AppendLine("'");
            sb.Append(", CityId='");
            sb.Append(CityId).AppendLine("'");
            sb.Append(", City='");
            sb.Append(City).AppendLine("'");
            sb.Append(", DistrictId='");
            sb.Append(DistrictId).AppendLine("'");
            sb.Append(", District='");
            sb.Append(District).AppendLine("'");
            sb.Append(", ZipCode='");
            sb.Append(ZipCode).AppendLine("'");
            sb.Append(", Street='");
            sb.Append(Street).AppendLine("'");
            sb.Append(", StreetId='");
            sb.Append(StreetId).AppendLine("'");
            sb.Append(", Address='");
            sb.Append(Address).AppendLine("'");
            sb.Append(", Consignee='");
            sb.Append(Consignee).AppendLine("'");
            sb.Append(", ConsigneeId='");
            sb.Append(ConsigneeId).AppendLine("'");
            sb.Append(", Mobile='");
            sb.Append(Mobile).AppendLine("'");
            sb.Append(", Phone='");
            sb.Append(Phone).AppendLine("'");
            sb.Append(", Email='");
            sb.Append(Email).AppendLine("'");
            sb.Append(", ConfirmRequired='");
            sb.Append(ConfirmRequired).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", DeliveryState='");
            sb.Append(DeliveryState).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", ItemsCount='");
            sb.Append(ItemsCount).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", DeliveryPeriod='");
            sb.Append(DeliveryPeriod).AppendLine("'");
            sb.Append(", Weight='");
            sb.Append(Weight).AppendLine("'");
            sb.Append(", DeliveryDate='");
            sb.Append(DeliveryDate).AppendLine("'");
            sb.Append(", ShippedDate='");
            sb.Append(ShippedDate).AppendLine("'");
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