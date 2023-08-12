using System;
using System.Collections.Generic;

namespace _3_PL.Models
{
    public partial class Sale
    {
        public int Id { get; set; }
        public string Ma { get; set; } = null!;
        public string Name { get; set; } = null!;
        public double? Discount { get; set; }
    }
}
