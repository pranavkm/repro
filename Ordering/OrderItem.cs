using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class OrderItem
    {
        /// <summary>
        /// 订单明细值
        /// </summary>
        [DataMember(Order = 40)]
        public List<OrderItemValue> Values { get; set; }

        /// <summary>
        /// Sku
        /// </summary>
        [DataMember(Order = 41)]
        public Sku Sku { get; set; }
    }
}
