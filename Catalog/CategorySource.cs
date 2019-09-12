using System.Collections.Generic;

namespace Pcs.Entity
{
    public partial class CategorySource
    {
        public CategorySource Parent { get; set; }

        public List<CategorySource> Children { get; set; }
    }
}
