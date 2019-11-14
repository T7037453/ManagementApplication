using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Data
{
    class Db : DbContext
    {
        public DbSet <PurchaseRequest> PurchaseRequests { get; set }
        public DbSet <StaffAccount> StaffAccounts { get; set; }

    }
}
