using System;
using System.Collections.Generic;

namespace QuanLyQuanTraSua.Models
{
    public partial class Account
    {
        public string UserName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int IdRole { get; set; }
        public double salary { get; set; }
        public string image { get; set; }
        public virtual RoleAccount IdRoleNavigation { get; set; } = null!;
    }
}
