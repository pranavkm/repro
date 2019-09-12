using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order_source
    /// </summary>
    [Table("order_source")]
    [DataContract]
    public partial class OrderSource
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.OrderSource"/>的构造函数
        /// </summary>
        public OrderSource()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        ///
        /// </summary>
        [Key]
        [Column("order_id")]
        [DataMember(Order = 0)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        ///
        /// </summary>
        [Column("utm_source")]
        [DataMember(Order = 1)]
        [StringLength(100)]
        public string UtmSource { get; set; } = string.Empty;      	
        /// <summary>
        ///
        /// </summary>
        [Column("utm_medium")]
        [DataMember(Order = 2)]
        [StringLength(200)]
        public string UtmMedium { get; set; } = string.Empty;      	
        /// <summary>
        ///
        /// </summary>
        [Column("utm_term")]
        [DataMember(Order = 3)]
        [StringLength(200)]
        public string UtmTerm { get; set; } = string.Empty;      	
        /// <summary>
        ///
        /// </summary>
        [Column("utm_content")]
        [DataMember(Order = 4)]
        [StringLength(300)]
        public string UtmContent { get; set; } = string.Empty;      	
        /// <summary>
        ///
        /// </summary>
        [Column("utm_compaig")]
        [DataMember(Order = 5)]
        [StringLength(300)]
        public string UtmCompaig { get; set; } = string.Empty;      	
        /// <summary>
        ///
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 6)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="orderSource"></param>        
        public virtual void CopyTo(OrderSource orderSource)
        {
            orderSource.OrderId = OrderId;
            orderSource.UtmSource = UtmSource;
            orderSource.UtmMedium = UtmMedium;
            orderSource.UtmTerm = UtmTerm;
            orderSource.UtmContent = UtmContent;
            orderSource.UtmCompaig = UtmCompaig;
            orderSource.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual OrderSource Clone()
        {
            var obj = new OrderSource();
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
            var sb = new System.Text.StringBuilder("OrderSource{");
            sb.Append("OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", UtmSource='");
            sb.Append(UtmSource).AppendLine("'");
            sb.Append(", UtmMedium='");
            sb.Append(UtmMedium).AppendLine("'");
            sb.Append(", UtmTerm='");
            sb.Append(UtmTerm).AppendLine("'");
            sb.Append(", UtmContent='");
            sb.Append(UtmContent).AppendLine("'");
            sb.Append(", UtmCompaig='");
            sb.Append(UtmCompaig).AppendLine("'");
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