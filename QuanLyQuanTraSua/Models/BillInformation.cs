using System;
using System.Collections.Generic;

namespace QuanLyQuanTraSua.Models
{
    public partial class BillInformation
    {
        public int IdBillInfor { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int? Quanlity { get; set; }

        public virtual Bill IdBillNavigation { get; set; } = null!;
        public virtual Food IdFoodNavigation { get; set; } = null!;
    }
}
