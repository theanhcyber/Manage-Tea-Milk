using System;
using System.Collections.Generic;

namespace QuanLyQuanTraSua.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillInformations = new HashSet<BillInformation>();
        }

        public int IdBill { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public int IdTable { get; set; }
        public bool Status { get; set; }
        public int discount { get; set; }

        public virtual TableFood IdTableNavigation { get; set; } = null!;
        public virtual ICollection<BillInformation> BillInformations { get; set; }
    }
}
