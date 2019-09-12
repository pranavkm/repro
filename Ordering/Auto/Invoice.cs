using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of invoice
    /// </summary>
    [Table("invoice")]
    [DataContract]
    public partial class Invoice
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Invoice"/>的构造函数
        /// </summary>
        public Invoice()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 发票Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 隶属于的订单Id
        /// </summary>
        [Column("order_id")]
        [DataMember(Order = 1)]
        public long OrderId { get; set; } = 0;      	
        /// <summary>
        /// 发票金额
        /// </summary>
        [Column("invoice_amount")]
        [DataMember(Order = 2)]
        public decimal InvoiceAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 货币单位,如:USD,CNY
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 3)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// 发票介质：0=为指定,1=纸质,2=电子,3=收单
        /// </summary>
        [Column("invoice_media")]
        [DataMember(Order = 4)]
        public int InvoiceMedia { get; set; } = 0;      	
        /// <summary>
        /// 发票类型：0=未指定,1=增值税,2=普通,3=定额,4=收据
        /// </summary>
        [Column("invoice_type")]
        [DataMember(Order = 5)]
        public int InvoiceType { get; set; } = 0;      	
        /// <summary>
        /// 发票抬头
        /// </summary>
        [Column("invoice_title")]
        [DataMember(Order = 6)]
        [StringLength(100)]
        public string InvoiceTitle { get; set; } = string.Empty;      	
        /// <summary>
        /// 发票内容，可能为 商品名称
        /// </summary>
        [Column("invoice_content")]
        [DataMember(Order = 7)]
        [StringLength(200)]
        public string InvoiceContent { get; set; } = string.Empty;      	
        /// <summary>
        /// 发票状态: 0=待开具;1=已开具;已配送
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 发票随寄包裹Id
        /// </summary>
        [Column("package_id")]
        [DataMember(Order = 9)]
        public long PackageId { get; set; } = (long)0;      	
        /// <summary>
        /// 发票随寄包裹单号
        /// </summary>
        [Column("package_no")]
        [DataMember(Order = 10)]
        [StringLength(30)]
        public string PackageNo { get; set; } = string.Empty;      	
        /// <summary>
        /// 发票快递公司
        /// </summary>
        [Column("express_id")]
        [DataMember(Order = 11)]
        public int ExpressId { get; set; } = (int)0;      	
        /// <summary>
        /// 发票快递公司名称
        /// </summary>
        [Column("express_name")]
        [DataMember(Order = 12)]
        [StringLength(100)]
        public string ExpressName { get; set; } = string.Empty;      	
        /// <summary>
        /// 发票抬头类型:0=未指定,1=个人发票,2=单位发票
        /// </summary>
        [Column("invoice_title_type")]
        [DataMember(Order = 13)]
        public int InvoiceTitleType { get; set; } = 0;      	
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [Column("tax_id_code")]
        [DataMember(Order = 14)]
        [StringLength(100)]
        public string TaxIdCode { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="invoice"></param>        
        public virtual void CopyTo(Invoice invoice)
        {
            invoice.Id = Id;
            invoice.OrderId = OrderId;
            invoice.InvoiceAmount = InvoiceAmount;
            invoice.Currency = Currency;
            invoice.InvoiceMedia = InvoiceMedia;
            invoice.InvoiceType = InvoiceType;
            invoice.InvoiceTitle = InvoiceTitle;
            invoice.InvoiceContent = InvoiceContent;
            invoice.State = State;
            invoice.PackageId = PackageId;
            invoice.PackageNo = PackageNo;
            invoice.ExpressId = ExpressId;
            invoice.ExpressName = ExpressName;
            invoice.InvoiceTitleType = InvoiceTitleType;
            invoice.TaxIdCode = TaxIdCode;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Invoice Clone()
        {
            var obj = new Invoice();
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
            var sb = new System.Text.StringBuilder("Invoice{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", OrderId='");
            sb.Append(OrderId).AppendLine("'");
            sb.Append(", InvoiceAmount='");
            sb.Append(InvoiceAmount).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", InvoiceMedia='");
            sb.Append(InvoiceMedia).AppendLine("'");
            sb.Append(", InvoiceType='");
            sb.Append(InvoiceType).AppendLine("'");
            sb.Append(", InvoiceTitle='");
            sb.Append(InvoiceTitle).AppendLine("'");
            sb.Append(", InvoiceContent='");
            sb.Append(InvoiceContent).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", PackageId='");
            sb.Append(PackageId).AppendLine("'");
            sb.Append(", PackageNo='");
            sb.Append(PackageNo).AppendLine("'");
            sb.Append(", ExpressId='");
            sb.Append(ExpressId).AppendLine("'");
            sb.Append(", ExpressName='");
            sb.Append(ExpressName).AppendLine("'");
            sb.Append(", InvoiceTitleType='");
            sb.Append(InvoiceTitleType).AppendLine("'");
            sb.Append(", TaxIdCode='");
            sb.Append(TaxIdCode).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}