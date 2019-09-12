using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of order
    /// </summary>
    [Table("order")]
    [DataContract]
    public partial class Order
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Order"/>的构造函数
        /// </summary>
        public Order()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 订单Id
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        public long Id { get; set; } = 0;      	
        /// <summary>
        /// 订单号
        /// </summary>
        [Column("sn")]
        [DataMember(Order = 1)]
        [StringLength(128)]
        public string Sn { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 2)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 订单金额=商品金额+运费+税额+其他金额-优惠金额
        /// </summary>
        [Column("total_amount")]
        [DataMember(Order = 3)]
        public decimal TotalAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 商品金额,正数
        /// </summary>
        [Column("net_amount")]
        [DataMember(Order = 4)]
        public decimal NetAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 优惠金额,正数
        /// </summary>
        [Column("discount_amount")]
        [DataMember(Order = 5)]
        public decimal DiscountAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 应付税额,正数，默认 0
        /// </summary>
        [Column("tax_amount")]
        [DataMember(Order = 6)]
        public decimal TaxAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 其他费用,正负数。
        /// </summary>
        [Column("other_amount")]
        [DataMember(Order = 7)]
        public decimal OtherAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 退款金额
        /// </summary>
        [Column("refund_amount")]
        [DataMember(Order = 8)]
        public decimal RefundAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 运费
        /// </summary>
        [Column("freight_charge")]
        [DataMember(Order = 9)]
        public decimal FreightCharge { get; set; } = 0.00m;      	
        /// <summary>
        /// 已支付金额，不计优惠金额。如使用余额，充值卡，银联卡，支付宝，微信等账户支付的累计金额
        /// </summary>
        [Column("payment_amount")]
        [DataMember(Order = 10)]
        public decimal PaymentAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 货币单位，如：USD,CNY
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 11)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// 订单状态:0=待确认;1=已确认;2=已取消;4=无效;8=退货,16=已拆分
        /// </summary>
        [Column("order_state")]
        [DataMember(Order = 12)]
        public int OrderState { get; set; } = 0;      	
        /// <summary>
        /// 支付状态:0=未付款;1=付款中;2=已付款
        /// </summary>
        [Column("payment_state")]
        [DataMember(Order = 13)]
        public int PaymentState { get; set; } = 0;      	
        /// <summary>
        /// 配送状态:0=未发货;1=备货中;2=部分发货;3=已发货,4=已送达,5=已收货(用户确认收货),6=未收货(用户没收货)
        /// </summary>
        [Column("shipping_state")]
        [DataMember(Order = 14)]
        public int ShippingState { get; set; } = 0;      	
        /// <summary>
        /// 退款状态:0=未发生,1=已申请,2=已确认,4=已拒绝,8=已退款
        /// </summary>
        [Column("refund_state")]
        [DataMember(Order = 15)]
        public int RefundState { get; set; } = 0;      	
        /// <summary>
        /// 退货状态:0=未发生,1=已申请,2=已确认,4=已拒绝,8=已退货
        /// </summary>
        [Column("return_state")]
        [DataMember(Order = 16)]
        public int ReturnState { get; set; } = 0;      	
        /// <summary>
        /// 支付方法:0=未指定,1=账户余额,2=CreditCard,3=DebitCard,4=微信支付,5=支付宝,6=Stripe,7=Paypal
        /// </summary>
        [Column("payment_method")]
        [DataMember(Order = 17)]
        public int PaymentMethod { get; set; } = 0;      	
        /// <summary>
        /// 配送方式:0=未指定,1=快递运输,2=自提
        /// </summary>
        [Column("shipping_method")]
        [DataMember(Order = 18)]
        public int ShippingMethod { get; set; } = 0;      	
        /// <summary>
        /// 用户手机
        /// </summary>
        [Column("user_mobile")]
        [DataMember(Order = 19)]
        [StringLength(20)]
        public string UserMobile { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户Ip
        /// </summary>
        [Column("user_ip")]
        [DataMember(Order = 20)]
        [StringLength(32)]
        public string UserIp { get; set; } = string.Empty;      	
        /// <summary>
        /// 用户终端:0=未指定;1=PC;2=APP;4=WAP;8=CALLCENTER;
        /// </summary>
        [Column("user_end")]
        [DataMember(Order = 21)]
        public int UserEnd { get; set; } = 0;      	
        /// <summary>
        /// 创建人Id，用户自己下单时与user_id一致
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 22)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 更新人Id
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 23)]
        public long UpdatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 24)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 更新时间，初次创建时与创建时间一致
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 25)]
        public DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 应用Id:0=未明确
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 26)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 业务类型:0=未明确;1=实物;2=服务;4=虚拟;8=押金;16:担保
        /// </summary>
        [Column("business_type")]
        [DataMember(Order = 27)]
        public int BusinessType { get; set; } = 0;      	
        /// <summary>
        /// 订单备注
        /// </summary>
        [Column("remark")]
        [DataMember(Order = 28)]
        [StringLength(500)]
        public string Remark { get; set; } = string.Empty;      	
        /// <summary>
        /// 订单确认时间
        /// </summary>
        [Column("confirm_time")]
        [DataMember(Order = 29)]
        public DateTimeOffset? ConfirmTime { get; set; } = null;      	
        /// <summary>
        /// 支付完成时间
        /// </summary>
        [Column("pay_time")]
        [DataMember(Order = 30)]
        public DateTimeOffset? PayTime { get; set; } = null;      	
        /// <summary>
        /// 配送交付时间
        /// </summary>
        [Column("deliver_time")]
        [DataMember(Order = 31)]
        public DateTimeOffset? DeliverTime { get; set; } = null;      	
        /// <summary>
        /// 退货到货时间
        /// </summary>
        [Column("return_time")]
        [DataMember(Order = 32)]
        public DateTimeOffset? ReturnTime { get; set; } = null;      	
        /// <summary>
        /// 退款支付时间
        /// </summary>
        [Column("refund_time")]
        [DataMember(Order = 33)]
        public DateTimeOffset? RefundTime { get; set; } = null;      	
        /// <summary>
        /// 支付方式:0=未指定，2=在线支付，1=货到付款，3=公司转账，4=邮局汇款
        /// </summary>
        [Column("payment_mode")]
        [DataMember(Order = 34)]
        public int? PaymentMode { get; set; } = (int)0;      	
        /// <summary>
        /// 总订单Id,0表示是总订单
        /// </summary>
        [Column("parent_id")]
        [DataMember(Order = 35)]
        public long ParentId { get; set; } = (long)0;      	
        /// <summary>
        /// 订单标题/名称
        /// </summary>
        [Column("title")]
        [DataMember(Order = 36)]
        [StringLength(500)]
        public string Title { get; set; } = null;      	
        /// <summary>
        /// 订单描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 37)]
        [StringLength(2000)]
        public string Description { get; set; } = null;      	
        /// <summary>
        /// 客户端标识
        /// </summary>
        [Column("client_id")]
        [DataMember(Order = 38)]
        [StringLength(100)]
        public string ClientId { get; set; } = string.Empty;      	
        /// <summary>
        /// 联盟推广标识
        /// </summary>
        [Column("affiliate_id")]
        [DataMember(Order = 39)]
        [StringLength(200)]
        public string AffiliateId { get; set; } = string.Empty;      	
        /// <summary>
        /// 带来订单的信息Id
        /// </summary>
        [Column("from_item_id")]
        [DataMember(Order = 40)]
        public long FromItemId { get; set; } = 0;      	
        /// <summary>
        /// 带来订单的信息贡献者Id
        /// </summary>
        [Column("from_contributor_id")]
        [DataMember(Order = 41)]
        public long FromContributorId { get; set; } = 0;      	
        /// <summary>
        /// 带来订单的用户Id
        /// </summary>
        [Column("from_user_id")]
        [DataMember(Order = 42)]
        public long FromUserId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="order"></param>        
        public virtual void CopyTo(Order order)
        {
            order.Id = Id;
            order.Sn = Sn;
            order.UserId = UserId;
            order.TotalAmount = TotalAmount;
            order.NetAmount = NetAmount;
            order.DiscountAmount = DiscountAmount;
            order.TaxAmount = TaxAmount;
            order.OtherAmount = OtherAmount;
            order.RefundAmount = RefundAmount;
            order.FreightCharge = FreightCharge;
            order.PaymentAmount = PaymentAmount;
            order.Currency = Currency;
            order.OrderState = OrderState;
            order.PaymentState = PaymentState;
            order.ShippingState = ShippingState;
            order.RefundState = RefundState;
            order.ReturnState = ReturnState;
            order.PaymentMethod = PaymentMethod;
            order.ShippingMethod = ShippingMethod;
            order.UserMobile = UserMobile;
            order.UserIp = UserIp;
            order.UserEnd = UserEnd;
            order.CreatedBy = CreatedBy;
            order.UpdatedBy = UpdatedBy;
            order.CreatedOn = CreatedOn;
            order.UpdatedOn = UpdatedOn;
            order.ApplicationId = ApplicationId;
            order.BusinessType = BusinessType;
            order.Remark = Remark;
            order.ConfirmTime = ConfirmTime;
            order.PayTime = PayTime;
            order.DeliverTime = DeliverTime;
            order.ReturnTime = ReturnTime;
            order.RefundTime = RefundTime;
            order.PaymentMode = PaymentMode;
            order.ParentId = ParentId;
            order.Title = Title;
            order.Description = Description;
            order.ClientId = ClientId;
            order.AffiliateId = AffiliateId;
            order.FromItemId = FromItemId;
            order.FromContributorId = FromContributorId;
            order.FromUserId = FromUserId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Order Clone()
        {
            var obj = new Order();
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
            var sb = new System.Text.StringBuilder("Order{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Sn='");
            sb.Append(Sn).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", TotalAmount='");
            sb.Append(TotalAmount).AppendLine("'");
            sb.Append(", NetAmount='");
            sb.Append(NetAmount).AppendLine("'");
            sb.Append(", DiscountAmount='");
            sb.Append(DiscountAmount).AppendLine("'");
            sb.Append(", TaxAmount='");
            sb.Append(TaxAmount).AppendLine("'");
            sb.Append(", OtherAmount='");
            sb.Append(OtherAmount).AppendLine("'");
            sb.Append(", RefundAmount='");
            sb.Append(RefundAmount).AppendLine("'");
            sb.Append(", FreightCharge='");
            sb.Append(FreightCharge).AppendLine("'");
            sb.Append(", PaymentAmount='");
            sb.Append(PaymentAmount).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", OrderState='");
            sb.Append(OrderState).AppendLine("'");
            sb.Append(", PaymentState='");
            sb.Append(PaymentState).AppendLine("'");
            sb.Append(", ShippingState='");
            sb.Append(ShippingState).AppendLine("'");
            sb.Append(", RefundState='");
            sb.Append(RefundState).AppendLine("'");
            sb.Append(", ReturnState='");
            sb.Append(ReturnState).AppendLine("'");
            sb.Append(", PaymentMethod='");
            sb.Append(PaymentMethod).AppendLine("'");
            sb.Append(", ShippingMethod='");
            sb.Append(ShippingMethod).AppendLine("'");
            sb.Append(", UserMobile='");
            sb.Append(UserMobile).AppendLine("'");
            sb.Append(", UserIp='");
            sb.Append(UserIp).AppendLine("'");
            sb.Append(", UserEnd='");
            sb.Append(UserEnd).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", BusinessType='");
            sb.Append(BusinessType).AppendLine("'");
            sb.Append(", Remark='");
            sb.Append(Remark).AppendLine("'");
            sb.Append(", ConfirmTime='");
            sb.Append(ConfirmTime).AppendLine("'");
            sb.Append(", PayTime='");
            sb.Append(PayTime).AppendLine("'");
            sb.Append(", DeliverTime='");
            sb.Append(DeliverTime).AppendLine("'");
            sb.Append(", ReturnTime='");
            sb.Append(ReturnTime).AppendLine("'");
            sb.Append(", RefundTime='");
            sb.Append(RefundTime).AppendLine("'");
            sb.Append(", PaymentMode='");
            sb.Append(PaymentMode).AppendLine("'");
            sb.Append(", ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", ClientId='");
            sb.Append(ClientId).AppendLine("'");
            sb.Append(", AffiliateId='");
            sb.Append(AffiliateId).AppendLine("'");
            sb.Append(", FromItemId='");
            sb.Append(FromItemId).AppendLine("'");
            sb.Append(", FromContributorId='");
            sb.Append(FromContributorId).AppendLine("'");
            sb.Append(", FromUserId='");
            sb.Append(FromUserId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}