using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class ItemPicture
    {
        /// <summary>
        /// 信息
        /// </summary>
        [DataMember(Order = 15)]
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [DataMember(Order = 16)]
        [ForeignKey(nameof(PictureId))]
        public Picture Picture { get; set; }
    }
}
