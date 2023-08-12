using System;
using System.Collections.Generic;

namespace _3_PL.Models
{
    public partial class Food
    {
        public Food()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdCategory { get; set; }
        public double Price { get; set; }
        public string? Images { get; set; }
        public int? Status { get; set; }

        public virtual FoodCategory IdCategoryNavigation { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
