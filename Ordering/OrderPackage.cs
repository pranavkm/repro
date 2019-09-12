using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class OrderPackage
    {
        /// <summary>
        /// 包裹信息
        /// </summary>
        [DataMember(Order = 15)]
        public Package Package { get; set; }

        /// <summary>
        /// 订单项信息
        /// </summary>
        [DataMember(Order = 16)]
        public OrderItem OrderItem { get; set; }
    }
}
