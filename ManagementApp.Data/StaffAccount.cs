using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Data
{
    public class StaffAccount
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public int PermissionID { get; set; }
        // Permissions Table with all Auth levels and actions (depends how auth server works)
        public Permission Permissions { get; set; }
    }
}
