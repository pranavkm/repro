using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    public partial class SkuSource
    {
        [DataMember(Order = 20)]
        public List<PictureSource> PictureSources { get; set; }

        [DataMember(Order = 21)]
        public CategorySource CategorySource { get; set; }

        [DataMember(Order = 22)]
        public BrandSource BrandSource { get; set; }
    }
}