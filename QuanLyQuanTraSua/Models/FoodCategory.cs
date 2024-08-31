using System;
using System.Collections.Generic;

namespace QuanLyQuanTraSua.Models
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }

        public int IdCategory { get; set; }
        public string? NameCategory { get; set; }
        public override string ToString()
        {
            return NameCategory;
        }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
