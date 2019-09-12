using System.Runtime.Serialization;

namespace Pcs.Entity
{
    public partial class Vendor
    {
        [DataMember(Order = 20)]
        public VendorSource Source { get; set; }
    }
}
