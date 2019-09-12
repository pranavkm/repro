using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_content
    /// </summary>
    [Table("item_content")]
    [DataContract]
    public partial class ItemContent
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemContent"/>的构造函数
        /// </summary>
        public ItemContent()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 内容id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 信息id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 属性id
        /// </summary>
        [Column("property_id")]
        [DataMember(Order = 2)]
        public int PropertyId { get; set; } = 0;      	
        /// <summary>
        /// 上级id
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 3)]
        public long ParentId { get; set; } = (long)0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 4)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 5)]
        [StringLength(500)]
        public string Title { get; set; } = string.Empty;      	
        /// <summary>
        /// 内容(格式转换后)
        /// </summary>
        [Column("content")]
        [DataMember(Order = 6)]
        public string Content { get; set; } = string.Empty;      	
        /// <summary>
        /// 排序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 7)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 顶级Id
        /// </summary>
        [Column("top_id")]
        [DataMember(Order = 9)]
        public int TopId { get; set; } = (int)0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 10)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 11)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 12)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 更新用户Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 13)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 14)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 15)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 原始内容
        /// </summary>
        [Column("raw")]
        [DataMember(Order = 16)]
        public string Raw { get; set; } = null;      	
        /// <summary>
        /// 原始内容格式,md=Markdown,html=HTML
        /// </summary>
        [Column("format")]
        [DataMember(Order = 17)]
        [StringLength(50)]
        public string Format { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemContent"></param>        
        public virtual void CopyTo(ItemContent itemContent)
        {
            itemContent.Id = Id;
            itemContent.ItemId = ItemId;
            itemContent.PropertyId = PropertyId;
            itemContent.ParentId = ParentId;
            itemContent.Name = Name;
            itemContent.Title = Title;
            itemContent.Content = Content;
            itemContent.SortNo = SortNo;
            itemContent.State = State;
            itemContent.TopId = TopId;
            itemContent.UserId = UserId;
            itemContent.CreatedOn = CreatedOn;
            itemContent.DataFlags = DataFlags;
            itemContent.UpdatedBy = UpdatedBy;
            itemContent.UpdatedOn = UpdatedOn;
            itemContent.CreatedBy = CreatedBy;
            itemContent.Raw = Raw;
            itemContent.Format = Format;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemContent Clone()
        {
            var obj = new ItemContent();
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
            var sb = new System.Text.StringBuilder("ItemContent{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", PropertyId='");
            sb.Append(PropertyId).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Content='");
            sb.Append(Content).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", TopId='");
            sb.Append(TopId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", Raw='");
            sb.Append(Raw).AppendLine("'");
            sb.Append(", Format='");
            sb.Append(Format).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}