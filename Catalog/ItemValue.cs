using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class ItemValue
    {
        /// <summary>
        /// 信息
        /// </summary>
        [DataMember(Order = 20)]
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }
    }
}
