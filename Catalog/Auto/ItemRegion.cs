using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_region
    /// </summary>
    [Table("item_region")]
    [DataContract]
    public partial class ItemRegion
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemRegion"/>的构造函数
        /// </summary>
        public ItemRegion()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 信息Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 地区Id
        /// </summary>
        [Column("region_id")]
        [DataMember(Order = 2)]
        public int RegionId { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 3)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 经度
        /// </summary>
        [Column("longitude")]
        [DataMember(Order = 5)]
        public double? Longitude { get; set; } = null;      	
        /// <summary>
        /// 纬度
        /// </summary>
        [Column("latitude")]
        [DataMember(Order = 6)]
        public double? Latitude { get; set; } = null;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 7)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 8)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemRegion"></param>        
        public virtual void CopyTo(ItemRegion itemRegion)
        {
            itemRegion.Id = Id;
            itemRegion.ItemId = ItemId;
            itemRegion.RegionId = RegionId;
            itemRegion.SortNo = SortNo;
            itemRegion.State = State;
            itemRegion.Longitude = Longitude;
            itemRegion.Latitude = Latitude;
            itemRegion.DataFlags = DataFlags;
            itemRegion.UserId = UserId;
            itemRegion.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemRegion Clone()
        {
            var obj = new ItemRegion();
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
            var sb = new System.Text.StringBuilder("ItemRegion{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", RegionId='");
            sb.Append(RegionId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", Longitude='");
            sb.Append(Longitude).AppendLine("'");
            sb.Append(", Latitude='");
            sb.Append(Latitude).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
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