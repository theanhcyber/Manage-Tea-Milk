using System;
using System.Collections.Generic;

namespace QuanLyQuanTraSua.Models
{
    public partial class RoleAccount
    {
        public RoleAccount()
        {
            Accounts = new HashSet<Account>();
        }

        public int IdRole { get; set; }
        public string? NameRole { get; set; }
        public string? Description { get; set; }
        public override string ToString()
        {
            return NameRole;
        }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
