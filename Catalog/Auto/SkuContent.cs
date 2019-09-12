using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of sku_content
    /// </summary>
    [Table("sku_content")]
    [DataContract]
    public partial class SkuContent
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.SkuContent"/>的构造函数
        /// </summary>
        public SkuContent()
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
        /// skuid
        /// </summary>
        [Column("sku_id")]
        [DataMember(Order = 1)]
        public long SkuId { get; set; } = 0;      	
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
        /// 内容
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
        [Column("data_flays")]
        [DataMember(Order = 12)]
        public long DataFlays { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="skuContent"></param>        
        public virtual void CopyTo(SkuContent skuContent)
        {
            skuContent.Id = Id;
            skuContent.SkuId = SkuId;
            skuContent.PropertyId = PropertyId;
            skuContent.ParentId = ParentId;
            skuContent.Name = Name;
            skuContent.Title = Title;
            skuContent.Content = Content;
            skuContent.SortNo = SortNo;
            skuContent.State = State;
            skuContent.TopId = TopId;
            skuContent.UserId = UserId;
            skuContent.CreatedOn = CreatedOn;
            skuContent.DataFlays = DataFlays;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual SkuContent Clone()
        {
            var obj = new SkuContent();
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
            var sb = new System.Text.StringBuilder("SkuContent{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", SkuId='");
            sb.Append(SkuId).AppendLine("'");
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
            sb.Append(", DataFlays='");
            sb.Append(DataFlays).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}