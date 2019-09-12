using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    public partial class CommisionRule
    {
        [DataMember(Order = 25)]
        public List<CommisionRuleSnapshot> Snapshots { get; set; }
    }
}