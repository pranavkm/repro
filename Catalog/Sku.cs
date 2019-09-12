using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class Sku
    {
        [DataMember(Order = 30)]
        public SkuSource Source { get; set; }

        [DataMember(Order = 31)]
        public List<SkuContent> Contents { get; set; }

        [DataMember(Order = 32)]
        public List<SkuValue> Values { get; set; }

        [DataMember(Order = 33)]
        public Vendor Vendor { get; set; }

        [DataMember(Order = 34)]
        public List<SkuPicture> Pictures { get; set; }

        [DataMember(Order = 35)]
        public Brand Brand { get; set; }

        [DataMember(Order = 36)]
        public Category Category { get; set; }
    }
}