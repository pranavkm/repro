using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class ItemTag
    {
        /// <summary>
        /// 信息
        /// </summary>
        [DataMember(Order = 15)]
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [DataMember(Order = 16)]
        [ForeignKey(nameof(TagId))]
        public Tag Tag { get; set; }
    }
}
