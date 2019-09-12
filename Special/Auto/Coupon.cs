using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of coupon
    /// </summary>
    [Table("coupon")]
    [DataContract]
    public partial class Coupon
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Coupon"/>的构造函数
        /// </summary>
        public Coupon()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 优惠券Id/码
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember(Order = 0)]
        [StringLength(64)]
        public string Id { get; set; } = string.Empty;      	
        /// <summary>
        /// 优惠策略Id。为0代表没有任何策略限制
        /// </summary>
        [Column("discount_policy_id")]
        [DataMember(Order = 1)]
        public int DiscountPolicyId { get; set; } = 0;      	
        /// <summary>
        /// 优惠名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 2)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 优惠类型1=折扣,2=抵扣,3=满减,4=限减
        /// </summary>
        [Column("discount_type")]
        [DataMember(Order = 3)]
        public sbyte DiscountType { get; set; } = 0;      	
        /// <summary>
        /// 优惠金额 抵扣/满减/限减代表现金值,折扣是1-100间
        /// </summary>
        [Column("discount_amount")]
        [DataMember(Order = 4)]
        public decimal DiscountAmount { get; set; } = 0.0m;      	
        /// <summary>
        /// 优惠券隶属商家
        /// </summary>
        [Column("merchant_id")]
        [DataMember(Order = 5)]
        public int MerchantId { get; set; } = 0;      	
        /// <summary>
        /// 优惠券有效开始时间
        /// </summary>
        [Column("valid_start_time")]
        [DataMember(Order = 6)]
        public DateTimeOffset ValidStartTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 优惠券有效截止时间
        /// </summary>
        [Column("valid_end_time")]
        [DataMember(Order = 7)]
        public DateTimeOffset ValidEndTime { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 8)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
        /// <summary>
        /// 优惠券状态0=待生效.1=可使用,2=已使用,3=已作废,4=已删除
        /// </summary>
        [Column("state")]
        [DataMember(Order = 9)]
        public int State { get; set; } = (int)0;      	
        /// <summary>
        /// 所有人/绑定的用户
        /// </summary>
        [Column("receive_by")]
        [DataMember(Order = 10)]
        public long? ReceiveBy { get; set; } = (long)0;      	
        /// <summary>
        /// 领取时间
        /// </summary>
        [Column("receive_time")]
        [DataMember(Order = 11)]
        public DateTimeOffset? ReceiveTime { get; set; } = null;      	
        /// <summary>
        /// 使用者
        /// </summary>
        [Column("used_by")]
        [DataMember(Order = 12)]
        public long? UsedBy { get; set; } = (long)0;      	
        /// <summary>
        /// 使用的金额
        /// </summary>
        [Column("used_amount")]
        [DataMember(Order = 13)]
        public decimal? UsedAmount { get; set; } = null;      	
        /// <summary>
        /// 使用时间
        /// </summary>
        [Column("used_time")]
        [DataMember(Order = 14)]
        public DateTimeOffset? UsedTime { get; set; } = null;      	
        /// <summary>
        /// 优惠备注信息
        /// </summary>
        [Column("memo")]
        [DataMember(Order = 15)]
        [StringLength(300)]
        public string Memo { get; set; } = string.Empty;      	
        /// <summary>
        /// 标题
        /// </summary>
        [Column("title")]
        [DataMember(Order = 16)]
        [StringLength(200)]
        public string Title { get; set; } = "NULL";      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 17)]
        [StringLength(500)]
        public string Description { get; set; } = "NULL";      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="coupon"></param>        
        public virtual void CopyTo(Coupon coupon)
        {
            coupon.Id = Id;
            coupon.DiscountPolicyId = DiscountPolicyId;
            coupon.Name = Name;
            coupon.DiscountType = DiscountType;
            coupon.DiscountAmount = DiscountAmount;
            coupon.MerchantId = MerchantId;
            coupon.ValidStartTime = ValidStartTime;
            coupon.ValidEndTime = ValidEndTime;
            coupon.CreatedOn = CreatedOn;
            coupon.State = State;
            coupon.ReceiveBy = ReceiveBy;
            coupon.ReceiveTime = ReceiveTime;
            coupon.UsedBy = UsedBy;
            coupon.UsedAmount = UsedAmount;
            coupon.UsedTime = UsedTime;
            coupon.Memo = Memo;
            coupon.Title = Title;
            coupon.Description = Description;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Coupon Clone()
        {
            var obj = new Coupon();
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
            var sb = new System.Text.StringBuilder("Coupon{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", DiscountPolicyId='");
            sb.Append(DiscountPolicyId).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", DiscountType='");
            sb.Append(DiscountType).AppendLine("'");
            sb.Append(", DiscountAmount='");
            sb.Append(DiscountAmount).AppendLine("'");
            sb.Append(", MerchantId='");
            sb.Append(MerchantId).AppendLine("'");
            sb.Append(", ValidStartTime='");
            sb.Append(ValidStartTime).AppendLine("'");
            sb.Append(", ValidEndTime='");
            sb.Append(ValidEndTime).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", ReceiveBy='");
            sb.Append(ReceiveBy).AppendLine("'");
            sb.Append(", ReceiveTime='");
            sb.Append(ReceiveTime).AppendLine("'");
            sb.Append(", UsedBy='");
            sb.Append(UsedBy).AppendLine("'");
            sb.Append(", UsedAmount='");
            sb.Append(UsedAmount).AppendLine("'");
            sb.Append(", UsedTime='");
            sb.Append(UsedTime).AppendLine("'");
            sb.Append(", Memo='");
            sb.Append(Memo).AppendLine("'");
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