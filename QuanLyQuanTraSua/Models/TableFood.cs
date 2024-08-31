using System;
using System.Collections.Generic;

namespace QuanLyQuanTraSua.Models
{
    public partial class TableFood
    {
        public TableFood()
        {
            Bills = new HashSet<Bill>();
        }

        public int IdTable { get; set; }
        public string? NameTable { get; set; }
        public bool? Status { get; set; }
        public int? MaximunPeople { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public override string ToString()
        {
            return NameTable;
        }
    }
}
