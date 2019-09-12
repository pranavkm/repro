namespace Pcs.Entity
{
    /// <summary>
    /// 订单商品属性值
    /// </summary>
    public class OrderSkuValue
    {
        /// <summary>
        /// 属性Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 属性Id
        /// </summary>
        public int PropertyId { get; set; }
        /// <summary>
        /// 属性名
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// 属性值(展示用)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 属性原始值
        /// </summary>
        public string Value { get; set; }

    }
}
