using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of relevance
    /// </summary>
    [Table("relevance")]
    [DataContract]
    public partial class Relevance
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Relevance"/>的构造函数
        /// </summary>
        public Relevance()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 关系定义代码
        /// </summary>
        [Key]
        [Column("code")]
        [DataMember(Order = 0)]
        [StringLength(20)]
        public string Code { get; set; } = string.Empty;      	
        /// <summary>
        /// 主数据id
        /// </summary>
        [Key]
        [Column("master_id")]
        [DataMember(Order = 1)]
        [StringLength(40)]
        public string MasterId { get; set; } = string.Empty;      	
        /// <summary>
        /// 从数据id
        /// </summary>
        [Key]
        [Column("slave_id")]
        [DataMember(Order = 2)]
        [StringLength(40)]
        public string SlaveId { get; set; } = string.Empty;      	
        /// <summary>
        /// 状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 3)]
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 排序id
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 4)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 数据标识位
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 5)]
        public long DataFlags { get; set; } = 0;      	
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 6)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 7)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 8)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column("extra_data")]
        [DataMember(Order = 9)]
        [StringLength(4000)]
        public string ExtraData { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="relevance"></param>        
        public virtual void CopyTo(Relevance relevance)
        {
            relevance.Code = Code;
            relevance.MasterId = MasterId;
            relevance.SlaveId = SlaveId;
            relevance.State = State;
            relevance.SortNo = SortNo;
            relevance.DataFlags = DataFlags;
            relevance.CreatedBy = CreatedBy;
            relevance.CreatedOn = CreatedOn;
            relevance.UserId = UserId;
            relevance.ExtraData = ExtraData;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Relevance Clone()
        {
            var obj = new Relevance();
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
            var sb = new System.Text.StringBuilder("Relevance{");
            sb.Append("Code='");
            sb.Append(Code).AppendLine("'");
            sb.Append(", MasterId='");
            sb.Append(MasterId).AppendLine("'");
            sb.Append(", SlaveId='");
            sb.Append(SlaveId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", ExtraData='");
            sb.Append(ExtraData).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}