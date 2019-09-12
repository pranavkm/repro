using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_file
    /// </summary>
    [Table("item_file")]
    [DataContract]
    public partial class ItemFile
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemFile"/>的构造函数
        /// </summary>
        public ItemFile()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 文件Id
        /// </summary>
        [Key]
        [Column("file_id")]
        [DataMember(Order = 0)]
        public long FileId { get; set; } = 0;      	
        /// <summary>
        /// 信息Id
        /// </summary>
        [Key]
        [Column("item_id")]
        [DataMember(Order = 1)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 2)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 分组Id
        /// </summary>
        [Column("group_id")]
        [DataMember(Order = 4)]
        public int GroupId { get; set; } = 0;      	
        /// <summary>
        /// 所属用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 5)]
        public long UserId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemFile"></param>        
        public virtual void CopyTo(ItemFile itemFile)
        {
            itemFile.FileId = FileId;
            itemFile.ItemId = ItemId;
            itemFile.CreatedBy = CreatedBy;
            itemFile.CreatedOn = CreatedOn;
            itemFile.GroupId = GroupId;
            itemFile.UserId = UserId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemFile Clone()
        {
            var obj = new ItemFile();
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
            var sb = new System.Text.StringBuilder("ItemFile{");
            sb.Append("FileId='");
            sb.Append(FileId).AppendLine("'");
            sb.Append(", ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", GroupId='");
            sb.Append(GroupId).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}