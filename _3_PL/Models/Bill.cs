using System;
using System.Collections.Generic;

namespace _3_PL.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public int Id { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int IdTable { get; set; }
        public int Status { get; set; }
        public double Discount { get; set; }

        public virtual TableFood IdTableNavigation { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
