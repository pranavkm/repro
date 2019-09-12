using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_log
    /// </summary>
    [Table("order_log")]
    [DataContract]
    public partial class OrderLog
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderLog"/>的构造函数
        /// </summary>
        public OrderLog()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 1)]
        public long OrderId { get; set; } = 0;      	
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
        /// 日志来源类型1=来自系统,2=来自用户
        /// </summary>
        [Column("source_type")]
        [DataMember(Order = 4)]
        public sbyte SourceType { get; set; } = 0;      	
        /// <summary>
        /// 序列化的方法1=json
        /// </summary>
        [Column("serialize_method")]
        [DataMember(Order = 5)]
        public sbyte SerializeMethod { get; set; } = 0;      	
        /// <summary>
        /// 日志标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 6)]
        [StringLength(300)]
        public string Title { get; set; } = string.Empty;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("descripion")]
        [DataMember(Order = 7)]
        [StringLength(1000)]
        public string Descripion { get; set; } = string.Empty;      	
        /// <summary>
        /// 序列化的日志数据,包括新旧数据
        /// </summary>
        [Column("data")]
        [DataMember(Order = 8)]
        public string Data { get; set; } = string.Empty;      	
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column("order_sn")]
        [DataMember(Order = 9)]
        [StringLength(128)]
        public string OrderSn { get; set; } = string.Empty;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderLog"></param>        
        public virtual void CopyTo(OrderLog orderLog)
        {
            orderLog.Id = Id;
            orderLog.OrderId = OrderId;
            orderLog.CreatedBy = CreatedBy;
            orderLog.CreatedOn = CreatedOn;
            orderLog.SourceType = SourceType;
            orderLog.SerializeMethod = SerializeMethod;
            orderLog.Title = Title;
            orderLog.Descripion = Descripion;
            orderLog.Data = Data;
            orderLog.OrderSn = OrderSn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderLog Clone()
        {
            var obj = new OrderLog();
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
            var sb = new System.Text.StringBuilder("OrderLog{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", SourceType='");
            sb.Append(SourceType).AppendLine("'");
            sb.Append(", SerializeMethod='");
            sb.Append(SerializeMethod).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Descripion='");
            sb.Append(Descripion).AppendLine("'");
            sb.Append(", Data='");
            sb.Append(Data).AppendLine("'");
            sb.Append(", OrderSn='");
            sb.Append(OrderSn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}