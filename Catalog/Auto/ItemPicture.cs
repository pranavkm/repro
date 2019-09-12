using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_picture
    /// </summary>
    [Table("item_picture")]
    [DataContract]
    public partial class ItemPicture
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemPicture"/>的构造函数
        /// </summary>
        public ItemPicture()
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
        /// 图片组Id
        /// </summary>
        [Column("group_id")]
        [DataMember(Order = 2)]
        public int GroupId { get; set; } = 0;      	
        /// <summary>
        /// 图片Id
        /// </summary>
        [Column("picture_id")]
        [DataMember(Order = 3)]
        public long PictureId { get; set; } = 0;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 4)]
        public int SortNo { get; set; } = (int)0;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 5)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 数据标识
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 6)]
        public int DataFlags { get; set; } = (int)0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 7)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 8)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 9)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 关系类型,1=信息图片,2=信息值图片,4=详情内容图片
        /// </summary>
        [Column("type")]
        [DataMember(Order = 10)]
        public int Type { get; set; } = 0;      	
        /// <summary>
        /// 根据type不同,保存信息值Id/信息内容Id
        /// </summary>
        [Column("object_id")]
        [DataMember(Order = 11)]
        public long ObjectId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemPicture"></param>        
        public virtual void CopyTo(ItemPicture itemPicture)
        {
            itemPicture.Id = Id;
            itemPicture.ItemId = ItemId;
            itemPicture.GroupId = GroupId;
            itemPicture.PictureId = PictureId;
            itemPicture.SortNo = SortNo;
            itemPicture.State = State;
            itemPicture.DataFlags = DataFlags;
            itemPicture.UserId = UserId;
            itemPicture.CreatedBy = CreatedBy;
            itemPicture.CreatedOn = CreatedOn;
            itemPicture.Type = Type;
            itemPicture.ObjectId = ObjectId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemPicture Clone()
        {
            var obj = new ItemPicture();
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
            var sb = new System.Text.StringBuilder("ItemPicture{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", GroupId='");
            sb.Append(GroupId).AppendLine("'");
            sb.Append(", PictureId='");
            sb.Append(PictureId).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", Type='");
            sb.Append(Type).AppendLine("'");
            sb.Append(", ObjectId='");
            sb.Append(ObjectId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}