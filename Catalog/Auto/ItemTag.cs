using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_tag
    /// </summary>
    [Table("item_tag")]
    [DataContract]
    public partial class ItemTag
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemTag"/>的构造函数
        /// </summary>
        public ItemTag()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 信息Id
        /// </summary>
        [Key]
        [Column("item_id")]
        [DataMember(Order = 0)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 标签Id
        /// </summary>
        [Key]
        [Column("tag_id")]
        [DataMember(Order = 1)]
        public int TagId { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 2)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 4)]
        public int SortNo { get; set; } = (int)0;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 5)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 标签名
        /// </summary>
        [Column("name")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemTag"></param>        
        public virtual void CopyTo(ItemTag itemTag)
        {
            itemTag.ItemId = ItemId;
            itemTag.TagId = TagId;
            itemTag.UserId = UserId;
            itemTag.CreatedOn = CreatedOn;
            itemTag.SortNo = SortNo;
            itemTag.DataFlags = DataFlags;
            itemTag.Name = Name;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemTag Clone()
        {
            var obj = new ItemTag();
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
            var sb = new System.Text.StringBuilder("ItemTag{");
            sb.Append("ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", TagId='");
            sb.Append(TagId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}