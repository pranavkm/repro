using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of package_track
    /// </summary>
    [Table("package_track")]
    [DataContract]
    public partial class PackageTrack
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.PackageTrack"/>的构造函数
        /// </summary>
        public PackageTrack()
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
        /// 快递单号
        /// </summary>
        [Column("package_no")]
        [DataMember(Order = 1)]
        [StringLength(20)]
        public string PackageNo { get; set; } = string.Empty;      	
        /// <summary>
        /// 包裹Id，可能为0
        /// </summary>
        [Column("package_id")]
        [DataMember(Order = 2)]
        public long PackageId { get; set; } = 0;      	
        /// <summary>
        /// 快递公司Id，可能为0
        /// </summary>
        [Column("express_id")]
        [DataMember(Order = 3)]
        public int ExpressId { get; set; } = (int)0;      	
        /// <summary>
        /// 快递公司名称
        /// </summary>
        [Column("express_name")]
        [DataMember(Order = 4)]
        [StringLength(100)]
        public string ExpressName { get; set; } = null;      	
        /// <summary>
        /// 快递状态：同Package.delivery_state
        /// </summary>
        [Column("delivery_state")]
        [DataMember(Order = 5)]
        public int DeliveryState { get; set; } = 0;      	
        /// <summary>
        /// 快递状态描述
        /// </summary>
        [Column("track_status")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string TrackStatus { get; set; } = null;      	
        /// <summary>
        /// 快递跟踪数据
        /// </summary>
        [Column("track_data")]
        [DataMember(Order = 7)]
        [StringLength(15000)]
        public string TrackData { get; set; } = string.Empty;      	
        /// <summary>
        /// 快递员姓名
        /// </summary>
        [Column("delivery_staff")]
        [DataMember(Order = 8)]
        [StringLength(20)]
        public string DeliveryStaff { get; set; } = string.Empty;      	
        /// <summary>
        /// 快递员手机/电话
        /// </summary>
        [Column("delivery_phone")]
        [DataMember(Order = 9)]
        [StringLength(20)]
        public string DeliveryPhone { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 10)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 创建人Id，可不要
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 11)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 最近同步数据时间
        /// </summary>
        [Column("last_sync_time")]
        [DataMember(Order = 12)]
        public DateTimeOffset LastSyncTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 跟踪数据状态
        /// </summary>
        [Column("last_sync_state")]
        [DataMember(Order = 13)]
        public int LastSyncState { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="packageTrack"></param>        
        public virtual void CopyTo(PackageTrack packageTrack)
        {
            packageTrack.Id = Id;
            packageTrack.PackageNo = PackageNo;
            packageTrack.PackageId = PackageId;
            packageTrack.ExpressId = ExpressId;
            packageTrack.ExpressName = ExpressName;
            packageTrack.DeliveryState = DeliveryState;
            packageTrack.TrackStatus = TrackStatus;
            packageTrack.TrackData = TrackData;
            packageTrack.DeliveryStaff = DeliveryStaff;
            packageTrack.DeliveryPhone = DeliveryPhone;
            packageTrack.CreatedOn = CreatedOn;
            packageTrack.CreatedBy = CreatedBy;
            packageTrack.LastSyncTime = LastSyncTime;
            packageTrack.LastSyncState = LastSyncState;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual PackageTrack Clone()
        {
            var obj = new PackageTrack();
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
            var sb = new System.Text.StringBuilder("PackageTrack{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", PackageNo='");
            sb.Append(PackageNo).AppendLine("'");
            sb.Append(", PackageId='");
            sb.Append(PackageId).AppendLine("'");
            sb.Append(", ExpressId='");
            sb.Append(ExpressId).AppendLine("'");
            sb.Append(", ExpressName='");
            sb.Append(ExpressName).AppendLine("'");
            sb.Append(", DeliveryState='");
            sb.Append(DeliveryState).AppendLine("'");
            sb.Append(", TrackStatus='");
            sb.Append(TrackStatus).AppendLine("'");
            sb.Append(", TrackData='");
            sb.Append(TrackData).AppendLine("'");
            sb.Append(", DeliveryStaff='");
            sb.Append(DeliveryStaff).AppendLine("'");
            sb.Append(", DeliveryPhone='");
            sb.Append(DeliveryPhone).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", LastSyncTime='");
            sb.Append(LastSyncTime).AppendLine("'");
            sb.Append(", LastSyncState='");
            sb.Append(LastSyncState).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}