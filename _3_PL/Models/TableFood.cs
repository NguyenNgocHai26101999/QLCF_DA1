using System;
using System.Collections.Generic;

namespace _3_PL.Models
{
    public partial class TableFood
    {
        public TableFood()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
