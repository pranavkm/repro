using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_address
    /// </summary>
    [Table("order_address")]
    [DataContract]
    public partial class OrderAddress
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderAddress"/>的构造函数
        /// </summary>
        public OrderAddress()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 1)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 标签名
        /// </summary>
        [Column("tag")]
        [DataMember(Order = 2)]
        [StringLength(100)]
        public string Tag { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 3)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 收货人姓名
        /// </summary>
        [Column("user_name")]
        [DataMember(Order = 4)]
        [StringLength(100)]
        public string UserName { get; set; } = string.Empty;      	
        /// <summary>
        /// 手机号
        /// </summary>
        [Column("mobile")]
        [DataMember(Order = 5)]
        [StringLength(20)]
        public string Mobile { get; set; } = string.Empty;      	
        /// <summary>
        /// 详细地址(街道,楼牌号等)
        /// </summary>
        [Column("address")]
        [DataMember(Order = 6)]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;      	
        /// <summary>
        /// 区县
        /// </summary>
        [Column("district")]
        [DataMember(Order = 7)]
        [StringLength(100)]
        public string District { get; set; } = string.Empty;      	
        /// <summary>
        /// 市
        /// </summary>
        [Column("city")]
        [DataMember(Order = 8)]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;      	
        /// <summary>
        /// 省
        /// </summary>
        [Column("province")]
        [DataMember(Order = 9)]
        [StringLength(100)]
        public string Province { get; set; } = string.Empty;      	
        /// <summary>
        /// 国家
        /// </summary>
        [Column("country")]
        [DataMember(Order = 10)]
        [StringLength(100)]
        public string Country { get; set; } = string.Empty;      	
        /// <summary>
        /// 邮编
        /// </summary>
        [Column("zip_code")]
        [DataMember(Order = 11)]
        [StringLength(50)]
        public string ZipCode { get; set; } = string.Empty;      	
        /// <summary>
        /// 国家Id
        /// </summary>
        [Column("country_id")]
        [DataMember(Order = 12)]
        public int CountryId { get; set; } = (int)0;      	
        /// <summary>
        /// 省/州Id
        /// </summary>
        [Column("province_id")]
        [DataMember(Order = 13)]
        public int ProvinceId { get; set; } = (int)0;      	
        /// <summary>
        /// 城市Id
        /// </summary>
        [Column("city_id")]
        [DataMember(Order = 14)]
        public int CityId { get; set; } = (int)0;      	
        /// <summary>
        /// 用户选择的最小地区Id
        /// </summary>
        [Column("region_id")]
        [DataMember(Order = 15)]
        public int RegionId { get; set; } = (int)0;      	
        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 16)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 17)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新人
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 18)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 19)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 用户地址Id
        /// </summary>
        [Column("user_address_id")]
        [DataMember(Order = 20)]
        public long UserAddressId { get; set; } = 0;      	
        /// <summary>
        /// 送货时间
        /// </summary>
        [Column("delivery_period")]
        [DataMember(Order = 21)]
        [StringLength(200)]
        public string DeliveryPeriod { get; set; } = string.Empty;      	
        /// <summary>
        /// 区县Id
        /// </summary>
        [Column("district_id")]
        [DataMember(Order = 22)]
        public int DistrictId { get; set; } = 0;      	
        /// <summary>
        /// 街道
        /// </summary>
        [Column("street")]
        [DataMember(Order = 23)]
        [StringLength(100)]
        public string Street { get; set; } = string.Empty;      	
        /// <summary>
        /// 街道Id，默认为0
        /// </summary>
        [Column("street_id")]
        [DataMember(Order = 24)]
        public int StreetId { get; set; } = 0;      	
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column("order_sn")]
        [DataMember(Order = 25)]
        [StringLength(128)]
        public string OrderSn { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户邮箱
        /// </summary>
        [Column("email")]
        [DataMember(Order = 26)]
        [StringLength(200)]
        public string Email { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderAddress"></param>        
        public virtual void CopyTo(OrderAddress orderAddress)
        {
            orderAddress.Id = Id;
            orderAddress.OrderId = OrderId;
            orderAddress.Tag = Tag;
            orderAddress.UserId = UserId;
            orderAddress.UserName = UserName;
            orderAddress.Mobile = Mobile;
            orderAddress.Address = Address;
            orderAddress.District = District;
            orderAddress.City = City;
            orderAddress.Province = Province;
            orderAddress.Country = Country;
            orderAddress.ZipCode = ZipCode;
            orderAddress.CountryId = CountryId;
            orderAddress.ProvinceId = ProvinceId;
            orderAddress.CityId = CityId;
            orderAddress.RegionId = RegionId;
            orderAddress.CreatedBy = CreatedBy;
            orderAddress.CreatedOn = CreatedOn;
            orderAddress.UpdatedBy = UpdatedBy;
            orderAddress.UpdatedOn = UpdatedOn;
            orderAddress.UserAddressId = UserAddressId;
            orderAddress.DeliveryPeriod = DeliveryPeriod;
            orderAddress.DistrictId = DistrictId;
            orderAddress.Street = Street;
            orderAddress.StreetId = StreetId;
            orderAddress.OrderSn = OrderSn;
            orderAddress.Email = Email;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderAddress Clone()
        {
            var obj = new OrderAddress();
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
            var sb = new System.Text.StringBuilder("OrderAddress{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", Tag='");
            sb.Append(Tag).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", UserName='");
            sb.Append(UserName).AppendLine("'");
            sb.Append(", Mobile='");
            sb.Append(Mobile).AppendLine("'");
            sb.Append(", Address='");
            sb.Append(Address).AppendLine("'");
            sb.Append(", District='");
            sb.Append(District).AppendLine("'");
            sb.Append(", City='");
            sb.Append(City).AppendLine("'");
            sb.Append(", Province='");
            sb.Append(Province).AppendLine("'");
            sb.Append(", Country='");
            sb.Append(Country).AppendLine("'");
            sb.Append(", ZipCode='");
            sb.Append(ZipCode).AppendLine("'");
            sb.Append(", CountryId='");
            sb.Append(CountryId).AppendLine("'");
            sb.Append(", ProvinceId='");
            sb.Append(ProvinceId).AppendLine("'");
            sb.Append(", CityId='");
            sb.Append(CityId).AppendLine("'");
            sb.Append(", RegionId='");
            sb.Append(RegionId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", UserAddressId='");
            sb.Append(UserAddressId).AppendLine("'");
            sb.Append(", DeliveryPeriod='");
            sb.Append(DeliveryPeriod).AppendLine("'");
            sb.Append(", DistrictId='");
            sb.Append(DistrictId).AppendLine("'");
            sb.Append(", Street='");
            sb.Append(Street).AppendLine("'");
            sb.Append(", StreetId='");
            sb.Append(StreetId).AppendLine("'");
            sb.Append(", OrderSn='");
            sb.Append(OrderSn).AppendLine("'");
            sb.Append(", Email='");
            sb.Append(Email).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}