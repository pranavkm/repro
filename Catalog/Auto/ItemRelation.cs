using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_relation
    /// </summary>
    [Table("item_relation")]
    [DataContract]
    public partial class ItemRelation
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemRelation"/>的构造函数
        /// </summary>
        public ItemRelation()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 关系Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 主信息Id
        /// </summary>
        [Column("master_id")]
        [DataMember(Order = 1)]
        public long MasterId { get; set; } = 0;      	
        /// <summary>
        /// 从信息Id
        /// </summary>
        [Column("slave_id")]
        [DataMember(Order = 2)]
        public long SlaveId { get; set; } = 0;      	
        /// <summary>
        /// 关系类型,由应用定义
        /// </summary>
        [Column("relation_type")]
        [DataMember(Order = 3)]
        public int RelationType { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 4)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 排序号
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 5)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 所属用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 6)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 7)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 8)]
        [StringLength(8000)]
        public string ExtraData { get; set; } = null;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 9)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 10)]
        public long CreatedBy { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemRelation"></param>        
        public virtual void CopyTo(ItemRelation itemRelation)
        {
            itemRelation.Id = Id;
            itemRelation.MasterId = MasterId;
            itemRelation.SlaveId = SlaveId;
            itemRelation.RelationType = RelationType;
            itemRelation.State = State;
            itemRelation.SortNo = SortNo;
            itemRelation.UserId = UserId;
            itemRelation.CreatedOn = CreatedOn;
            itemRelation.ExtraData = ExtraData;
            itemRelation.DataFlags = DataFlags;
            itemRelation.CreatedBy = CreatedBy;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemRelation Clone()
        {
            var obj = new ItemRelation();
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
            var sb = new System.Text.StringBuilder("ItemRelation{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", MasterId='");
            sb.Append(MasterId).AppendLine("'");
            sb.Append(", SlaveId='");
            sb.Append(SlaveId).AppendLine("'");
            sb.Append(", RelationType='");
            sb.Append(RelationType).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}