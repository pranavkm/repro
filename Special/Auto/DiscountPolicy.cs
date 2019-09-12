using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of discount_policy
    /// </summary>
    [Table("discount_policy")]
    [DataContract]
    public partial class DiscountPolicy
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.DiscountPolicy"/>的构造函数
        /// </summary>
        public DiscountPolicy()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 优惠id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 优惠名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 隶属商家，默认为0代表平台范围
        /// </summary>
        [Column("merchant_id")]
        [DataMember(Order = 2)]
        public int MerchantId { get; set; } = (int)0;      	
        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        [DataMember(Order = 3)]
        public long CreatedBy { get; set; } = 0;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 4)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 优惠类型1=折扣,2=抵扣,3=满减,4=限减
        /// </summary>
        [Column("discount_type")]
        [DataMember(Order = 5)]
        public int DiscountType { get; set; } = 0;      	
        /// <summary>
        /// 优惠金额 抵扣/满减/限减代表现金值,折扣是1-100间
        /// </summary>
        [Column("discount_amount")]
        [DataMember(Order = 6)]
        public decimal DiscountAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 货币单位,如:USD,CNY
        /// </summary>
        [Column("currency")]
        [DataMember(Order = 7)]
        [StringLength(3)]
        public string Currency { get; set; } = string.Empty;      	
        /// <summary>
        /// 最大优惠金额,0表示不限,(如500,打折券5折,最高不超过500元)
        /// </summary>
        [Column("discount_limit")]
        [DataMember(Order = 8)]
        public decimal DiscountLimit { get; set; } = 0.00m;      	
        /// <summary>
        /// 优惠可独立使用。0表示不可独立使用，比如隶属于优惠券
        /// </summary>
        [Column("independ_use")]
        [DataMember(Order = 9)]
        public bool IndependUse { get; set; } = false;      	
        /// <summary>
        /// 优惠备注信息
        /// </summary>
        [Column("memo")]
        [DataMember(Order = 10)]
        [StringLength(300)]
        public string Memo { get; set; } = string.Empty;      	
        /// <summary>
        /// 可使用时间,是一个cron表达式
        /// </summary>
        [Column("valid_time_exp")]
        [DataMember(Order = 11)]
        [StringLength(50)]
        public string ValidTimeExp { get; set; } = string.Empty;      	
        /// <summary>
        /// 使用时最低消费金额,如消费满100元才可用。0表示无限制
        /// </summary>
        [Column("starting_amount")]
        [DataMember(Order = 12)]
        public decimal StartingAmount { get; set; } = 0.00m;      	
        /// <summary>
        /// 购买数量要求。比如 2件6折 3件5折
        /// </summary>
        [Column("starting_quantity")]
        [DataMember(Order = 13)]
        public decimal StartingQuantity { get; set; } = 0.000000m;      	
        /// <summary>
        /// 前N个用户，N+1就没有优惠了。默认为0，无限制
        /// </summary>
        [Column("first_users")]
        [DataMember(Order = 14)]
        public int FirstUsers { get; set; } = (int)0;      	
        /// <summary>
        /// 首单才可使用，无论之前是否使用过优惠。默认为0:false
        /// </summary>
        [Column("first_order_only")]
        [DataMember(Order = 15)]
        public bool FirstOrderOnly { get; set; } = false;      	
        /// <summary>
        /// 1个用户只能使用1次。默认0:false
        /// </summary>
        [Column("once_per_user")]
        [DataMember(Order = 16)]
        public bool OncePerUser { get; set; } = false;      	
        /// <summary>
        /// 1个优惠资格可重复使用。这种情况优惠只需要领取一次。默认0:false
        /// </summary>
        [Column("reusable")]
        [DataMember(Order = 17)]
        public bool Reusable { get; set; } = false;      	
        /// <summary>
        /// 可叠加使用。默认为0:false
        /// </summary>
        [Column("multiple_use")]
        [DataMember(Order = 18)]
        public bool MultipleUse { get; set; } = false;      	
        /// <summary>
        /// 不与其他优惠一起使用。默认为1:true
        /// </summary>
        [Column("exclusive_use")]
        [DataMember(Order = 19)]
        public bool ExclusiveUse { get; set; } = false;      	
        /// <summary>
        /// 自动适用，是指用户无需领取自动根据适用条件进行计算享受优惠。默认为0:false
        /// </summary>
        [Column("auto_applicable")]
        [DataMember(Order = 20)]
        public bool AutoApplicable { get; set; } = false;      	
        /// <summary>
        /// 使用限制类型 0=无限制,是位与值
        /// </summary>
        [Column("additional_restrict")]
        [DataMember(Order = 21)]
        public int AdditionalRestrict { get; set; } = (int)0;      	
        /// <summary>
        /// 优惠开始时间
        /// </summary>
        [Column("begin_time")]
        [DataMember(Order = 22)]
        public DateTimeOffset BeginTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 优惠结束时间
        /// </summary>
        [Column("end_time")]
        [DataMember(Order = 23)]
        public DateTimeOffset EndTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 状态0=未生效,1=有效,2=暂停,3=已作废,4=已删除。已删除的，所有者也不可见。之有平台管理员才可见
        /// </summary>
        [Column("state")]
        [DataMember(Order = 24)]
        public int State { get; set; } = (int)0;      	
        /// <summary>
        /// 审核状态0=待审核,1=通过,2=拒绝
        /// </summary>
        [Column("audit_state")]
        [DataMember(Order = 25)]
        public int AuditState { get; set; } = (int)0;      	
        /// <summary>
        /// 审核人
        /// </summary>
        [Column("audited_by")]
        [DataMember(Order = 26)]
        public long? AuditedBy { get; set; } = null;      	
        /// <summary>
        /// 审核时间
        /// </summary>
        [Column("audited_on")]
        [DataMember(Order = 27)]
        public DateTimeOffset? AuditedOn { get; set; } = null;      	
        /// <summary>
        /// 更新者。首次创建时与create_by相同
        /// </summary>
        [Column("updated_by")]
        [DataMember(Order = 28)]
        public long? UpdatedBy { get; set; } = null;      	
        /// <summary>
        /// 更新时间。首次创建时与create_time相同
        /// </summary>
        [Column("updated_on")]
        [DataMember(Order = 29)]
        public DateTimeOffset? UpdatedOn { get; set; } = null;      	
        /// <summary>
        /// 推荐Id。比如id1被修改了核心意义字段，则id1被作废，同时产生了id2，id2的referral_id就是id1
        /// </summary>
        [Column("referral_id")]
        [DataMember(Order = 30)]
        public int? ReferralId { get; set; } = (int)0;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 31)]
        [StringLength(200)]
        public string Title { get; set; } = "NULL";      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 32)]
        [StringLength(500)]
        public string Description { get; set; } = "NULL";      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="discountPolicy"></param>        
        public virtual void CopyTo(DiscountPolicy discountPolicy)
        {
            discountPolicy.Id = Id;
            discountPolicy.Name = Name;
            discountPolicy.MerchantId = MerchantId;
            discountPolicy.CreatedBy = CreatedBy;
            discountPolicy.CreatedOn = CreatedOn;
            discountPolicy.DiscountType = DiscountType;
            discountPolicy.DiscountAmount = DiscountAmount;
            discountPolicy.Currency = Currency;
            discountPolicy.DiscountLimit = DiscountLimit;
            discountPolicy.IndependUse = IndependUse;
            discountPolicy.Memo = Memo;
            discountPolicy.ValidTimeExp = ValidTimeExp;
            discountPolicy.StartingAmount = StartingAmount;
            discountPolicy.StartingQuantity = StartingQuantity;
            discountPolicy.FirstUsers = FirstUsers;
            discountPolicy.FirstOrderOnly = FirstOrderOnly;
            discountPolicy.OncePerUser = OncePerUser;
            discountPolicy.Reusable = Reusable;
            discountPolicy.MultipleUse = MultipleUse;
            discountPolicy.ExclusiveUse = ExclusiveUse;
            discountPolicy.AutoApplicable = AutoApplicable;
            discountPolicy.AdditionalRestrict = AdditionalRestrict;
            discountPolicy.BeginTime = BeginTime;
            discountPolicy.EndTime = EndTime;
            discountPolicy.State = State;
            discountPolicy.AuditState = AuditState;
            discountPolicy.AuditedBy = AuditedBy;
            discountPolicy.AuditedOn = AuditedOn;
            discountPolicy.UpdatedBy = UpdatedBy;
            discountPolicy.UpdatedOn = UpdatedOn;
            discountPolicy.ReferralId = ReferralId;
            discountPolicy.Title = Title;
            discountPolicy.Description = Description;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual DiscountPolicy Clone()
        {
            var obj = new DiscountPolicy();
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
            var sb = new System.Text.StringBuilder("DiscountPolicy{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", MerchantId='");
            sb.Append(MerchantId).AppendLine("'");
            sb.Append(", CreatedBy='");
            sb.Append(CreatedBy).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", DiscountType='");
            sb.Append(DiscountType).AppendLine("'");
            sb.Append(", DiscountAmount='");
            sb.Append(DiscountAmount).AppendLine("'");
            sb.Append(", Currency='");
            sb.Append(Currency).AppendLine("'");
            sb.Append(", DiscountLimit='");
            sb.Append(DiscountLimit).AppendLine("'");
            sb.Append(", IndependUse='");
            sb.Append(IndependUse).AppendLine("'");
            sb.Append(", Memo='");
            sb.Append(Memo).AppendLine("'");
            sb.Append(", ValidTimeExp='");
            sb.Append(ValidTimeExp).AppendLine("'");
            sb.Append(", StartingAmount='");
            sb.Append(StartingAmount).AppendLine("'");
            sb.Append(", StartingQuantity='");
            sb.Append(StartingQuantity).AppendLine("'");
            sb.Append(", FirstUsers='");
            sb.Append(FirstUsers).AppendLine("'");
            sb.Append(", FirstOrderOnly='");
            sb.Append(FirstOrderOnly).AppendLine("'");
            sb.Append(", OncePerUser='");
            sb.Append(OncePerUser).AppendLine("'");
            sb.Append(", Reusable='");
            sb.Append(Reusable).AppendLine("'");
            sb.Append(", MultipleUse='");
            sb.Append(MultipleUse).AppendLine("'");
            sb.Append(", ExclusiveUse='");
            sb.Append(ExclusiveUse).AppendLine("'");
            sb.Append(", AutoApplicable='");
            sb.Append(AutoApplicable).AppendLine("'");
            sb.Append(", AdditionalRestrict='");
            sb.Append(AdditionalRestrict).AppendLine("'");
            sb.Append(", BeginTime='");
            sb.Append(BeginTime).AppendLine("'");
            sb.Append(", EndTime='");
            sb.Append(EndTime).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", AuditState='");
            sb.Append(AuditState).AppendLine("'");
            sb.Append(", AuditedBy='");
            sb.Append(AuditedBy).AppendLine("'");
            sb.Append(", AuditedOn='");
            sb.Append(AuditedOn).AppendLine("'");
            sb.Append(", UpdatedBy='");
            sb.Append(UpdatedBy).AppendLine("'");
            sb.Append(", UpdatedOn='");
            sb.Append(UpdatedOn).AppendLine("'");
            sb.Append(", ReferralId='");
            sb.Append(ReferralId).AppendLine("'");
            sb.Append(", Title='");
            sb.Append(Title).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}