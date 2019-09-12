using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of sku_picture
    /// </summary>
    [Table("sku_picture")]
    [DataContract]
    public partial class SkuPicture
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.SkuPicture"/>的构造函数
        /// </summary>
        public SkuPicture()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// SkuId
        /// </summary>
        [Key]
        [Column("sku_id")]
        [DataMember(Order = 0)]
        public long SkuId { get; set; } = 0;      	
        /// <summary>
        /// 图片Id
        /// </summary>
        [Key]
        [Column("picture_id")]
        [DataMember(Order = 1)]
        public long PictureId { get; set; } = 0;      	
        /// <summary>
        /// 商品Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 2)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 3)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 图片分组Id
        /// </summary>
        [Column("group_id")]
        [DataMember(Order = 4)]
        public int GroupId { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 5)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 7)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="skuPicture"></param>        
        public virtual void CopyTo(SkuPicture skuPicture)
        {
            skuPicture.SkuId = SkuId;
            skuPicture.PictureId = PictureId;
            skuPicture.ItemId = ItemId;
            skuPicture.SortNo = SortNo;
            skuPicture.GroupId = GroupId;
            skuPicture.UserId = UserId;
            skuPicture.CreatedOn = CreatedOn;
            skuPicture.DataFlags = DataFlags;
            skuPicture.State = State;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual SkuPicture Clone()
        {
            var obj = new SkuPicture();
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
            var sb = new System.Text.StringBuilder("SkuPicture{");
            sb.Append("SkuId='");
            sb.Append(SkuId).AppendLine("'");
            sb.Append(", PictureId='");
            sb.Append(PictureId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", GroupId='");
            sb.Append(GroupId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
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