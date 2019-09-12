using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_source
    /// </summary>
    [Table("item_source")]
    [DataContract]
    public partial class ItemSource
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemSource"/>的构造函数
        /// </summary>
        public ItemSource()
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
        /// url地址
        /// </summary>
        [Column("url")]
        [DataMember(Order = 1)]
        [StringLength(500)]
        public string Url { get; set; } = string.Empty;      	
        /// <summary>
        /// 外部数据Id
        /// </summary>
        [Column("unique_id")]
        [DataMember(Order = 2)]
        [StringLength(128)]
        public string UniqueId { get; set; } = string.Empty;      	
        /// <summary>
        /// 外部来源名(如amazon)
        /// </summary>
        [Column("source_name")]
        [DataMember(Order = 3)]
        [StringLength(64)]
        public string SourceName { get; set; } = string.Empty;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 4)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 5)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 6)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 7)]
        public string ExtraData { get; set; } = null;      	
        /// <summary>
        /// 关联的信息Id
        /// </summary>
        [Column("item_id")]
        [DataMember(Order = 8)]
        public long? ItemId { get; set; } = null;      	
        /// <summary>
        /// 创建用户id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 9)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 原作者
        /// </summary>
        [Column("author")]
        [DataMember(Order = 10)]
        [StringLength(100)]
        public string Author { get; set; } = null;      	
        /// <summary>
        /// 原出处
        /// </summary>
        [Column("source_from")]
        [DataMember(Order = 11)]
        [StringLength(100)]
        public string SourceFrom { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemSource"></param>        
        public virtual void CopyTo(ItemSource itemSource)
        {
            itemSource.Id = Id;
            itemSource.Url = Url;
            itemSource.UniqueId = UniqueId;
            itemSource.SourceName = SourceName;
            itemSource.CreatedOn = CreatedOn;
            itemSource.UpdatedOn = UpdatedOn;
            itemSource.Name = Name;
            itemSource.ExtraData = ExtraData;
            itemSource.ItemId = ItemId;
            itemSource.CreatedBy = CreatedBy;
            itemSource.Author = Author;
            itemSource.SourceFrom = SourceFrom;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemSource Clone()
        {
            var obj = new ItemSource();
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
            var sb = new System.Text.StringBuilder("ItemSource{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Url='");
            sb.Append(Url).AppendLine("'");
            sb.Append(", UniqueId='");
            sb.Append(UniqueId).AppendLine("'");
            sb.Append(", SourceName='");
            sb.Append(SourceName).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", Author='");
            sb.Append(Author).AppendLine("'");
            sb.Append(", SourceFrom='");
            sb.Append(SourceFrom).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}