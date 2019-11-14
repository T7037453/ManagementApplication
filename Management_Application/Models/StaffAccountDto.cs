using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementApp.Data;

namespace ManagementApp.Web.Models
{
    public class StaffAccountDto
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public int PermissionID { get; set; }
        // Permissions Table with all Auth levels and actions (depends how auth server works)
        public Permission Permissions { get; set; }
    }
}
