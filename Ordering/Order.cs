using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    public partial class Order
    {
        /// <summary>
        /// 订单项集合
        /// </summary>
        [DataMember(Order = 50)]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// 订单折扣集合
        /// </summary>
        [DataMember(Order = 51)]
        public List<OrderDiscount> OrderDiscounts { get; set; }

        /// <summary>
        /// 订单支付信息集合
        /// </summary>
        [DataMember(Order = 52)]
        public List<OrderPayment> OrderPayments { get; set; }

        /// <summary>
        /// 订单的发票集合
        /// </summary>
        [DataMember(Order = 53)]
        public List<Invoice> Invoices { get; set; }

        /// <summary>
        /// 订单包裹集合
        /// </summary>
        [DataMember(Order = 54)]
        public List<OrderPackage> OrderPackages { get; set; }

        /// <summary>
        /// 订单地址
        /// </summary>
        [DataMember(Order = 55)]
        public OrderAddress Address { get; set; }

        /// <summary>
        /// 子订单集合
        /// </summary>
        [DataMember(Order = 56)]
        public List<Order> SubOrders { get; set; }
    }
}