using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_note
    /// </summary>
    [Table("order_note")]
    [DataContract]
    public partial class OrderNote
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderNote"/>的构造函数
        /// </summary>
        public OrderNote()
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
        /// 备注内容
        /// </summary>
        [Column("note")]
        [DataMember(Order = 2)]
        [StringLength(8000)]
        public string Note { get; set; } = string.Empty;      	
        /// <summary>
        /// 是否用户可见
        /// </summary>
        [Column("customer_visible")]
        [DataMember(Order = 3)]
        public bool CustomerVisible { get; set; } = false;      	
        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 4)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 5)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderNote"></param>        
        public virtual void CopyTo(OrderNote orderNote)
        {
            orderNote.Id = Id;
            orderNote.OrderId = OrderId;
            orderNote.Note = Note;
            orderNote.CustomerVisible = CustomerVisible;
            orderNote.CreatedBy = CreatedBy;
            orderNote.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderNote Clone()
        {
            var obj = new OrderNote();
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
            var sb = new System.Text.StringBuilder("OrderNote{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", Note='");
            sb.Append(Note).AppendLine("'");
            sb.Append(", CustomerVisible='");
            sb.Append(CustomerVisible).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}