using System;
using System.Collections.Generic;

namespace QuanLyQuanTraSua.Models
{
    public partial class Food
    {
        public Food()
        {
            BillInformations = new HashSet<BillInformation>();
        }

        public int IdFood { get; set; }
        public string NameFood { get; set; } = null!;
        public int IdCategory { get; set; }
        public double PriceFood { get; set; }
        
        public override string ToString()
        {
            return NameFood;
        }
        public virtual FoodCategory IdCategoryNavigation { get; set; } = null!;
        public virtual ICollection<BillInformation> BillInformations { get; set; }
    }
}
