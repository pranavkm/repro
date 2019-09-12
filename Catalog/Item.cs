using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class Item
    {
        /// <summary>
        /// 属性值集合
        /// </summary>
        [DataMember(Order = 40)]
        [InverseProperty(nameof(ItemValue.Item))]
        public virtual List<ItemValue> Values { get; set; }

        /// <summary>
        /// 发布分类集合
        /// </summary>
        [DataMember(Order = 41)]
        [InverseProperty(nameof(ItemCategory.Item))]
        public virtual List<ItemCategory> Categories { get; set; }

        /// <summary>
        /// 内容集合
        /// </summary>
        [DataMember(Order = 42)]
        [InverseProperty(nameof(ItemContent.Item))]
        public virtual List<ItemContent> Contents { get; set; }

        /// <summary>
        /// 发布地区集合
        /// </summary>
        [DataMember(Order = 43)]
        [InverseProperty(nameof(ItemRegion.Item))]
        public virtual List<ItemRegion> Regions { get; set; }

        /// <summary>
        /// 图片集合
        /// </summary>
        [DataMember(Order = 44)]
        [InverseProperty(nameof(ItemPicture.Item))]
        public virtual List<ItemPicture> Pictures { get; set; }

        /// <summary>
        /// 标签集合
        /// </summary>
        [DataMember(Order = 45)]
        [InverseProperty(nameof(ItemTag.Item))]
        public virtual List<ItemTag> Tags { get; set; }

        /// <summary>
        /// 来源集合
        /// </summary>
        [DataMember(Order = 46)]
        public virtual ItemSource ItemSource { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [DataMember(Order = 47)]
        public virtual Brand Brand { get; set; }

        /// <summary>
        /// 所属分类
        /// </summary>
        [DataMember(Order = 48)]
        public virtual Category Category { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [DataMember(Order = 49)]
        public virtual Merchant Merchant { get; set; }
    }
}
