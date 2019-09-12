using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of warehouse
    /// </summary>
    [Table("warehouse")]
    [DataContract]
    public partial class Warehouse
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Warehouse"/>的构造函数
        /// </summary>
        public Warehouse()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 详细地址
        /// </summary>
        [Column("address")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 3)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 用户id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 4)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 5)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 省
        /// </summary>
        [Column("province")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string Province { get; set; } = string.Empty;      	
        /// <summary>
        /// 市
        /// </summary>
        [Column("city")]
        [DataMember(Order = 7)]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;      	
        /// <summary>
        /// 区县
        /// </summary>
        [Column("district")]
        [DataMember(Order = 8)]
        [StringLength(100)]
        public string District { get; set; } = string.Empty;      	
        /// <summary>
        /// 省/州Id
        /// </summary>
        [Column("province_id")]
        [DataMember(Order = 9)]
        public int ProvinceId { get; set; } = 0;      	
        /// <summary>
        /// 城市Id
        /// </summary>
        [Column("city_id")]
        [DataMember(Order = 10)]
        public int CityId { get; set; } = 0;      	
        /// <summary>
        /// 选择的最小地区Id
        /// </summary>
        [Column("region_id")]
        [DataMember(Order = 11)]
        public int RegionId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 12)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="warehouse"></param>        
        public virtual void CopyTo(Warehouse warehouse)
        {
            warehouse.Id = Id;
            warehouse.Name = Name;
            warehouse.Address = Address;
            warehouse.State = State;
            warehouse.UserId = UserId;
            warehouse.CreatedBy = CreatedBy;
            warehouse.Province = Province;
            warehouse.City = City;
            warehouse.District = District;
            warehouse.ProvinceId = ProvinceId;
            warehouse.CityId = CityId;
            warehouse.RegionId = RegionId;
            warehouse.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Warehouse Clone()
        {
            var obj = new Warehouse();
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
            var sb = new System.Text.StringBuilder("Warehouse{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Address='");
            sb.Append(Address).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", Province='");
            sb.Append(Province).AppendLine("'");
            sb.Append(", City='");
            sb.Append(City).AppendLine("'");
            sb.Append(", District='");
            sb.Append(District).AppendLine("'");
            sb.Append(", ProvinceId='");
            sb.Append(ProvinceId).AppendLine("'");
            sb.Append(", CityId='");
            sb.Append(CityId).AppendLine("'");
            sb.Append(", RegionId='");
            sb.Append(RegionId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}