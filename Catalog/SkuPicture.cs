using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class SkuPicture
    {
        /// <summary>
        /// Sku
        /// </summary>
        [DataMember(Order = 15)]
        [ForeignKey(nameof(SkuId))]
        public Sku Sku { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [DataMember(Order = 16)]
        [ForeignKey(nameof(PictureId))]
        public Picture Picture { get; set; }
    }
}
