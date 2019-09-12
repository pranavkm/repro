namespace Pcs.Entity
{
    public class ItemRelationTypes
    {
        /// <summary>
        /// 评测的产品，MasterId=评测id，SlaveId=产品Id
        /// </summary>
        public const int Product = 1001;

        /// <summary>
        /// 评测关联的售卖商品,MasterId=评测id，SlaveId=商品Id
        /// </summary>
        public const int Commodity = 1002;
    }
}
