using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.Data
{
    public static class DbInitialiser
    {
        public static async Task SeedTestData(Db context,
                                             IServiceProvider services)
        {
            var StaffAccounts = new List<StaffAccount>
            {
                new StaffAccount { StaffID = 42, Name = "Jordan", PermissionID = 4}
            };
            StaffAccounts.ForEach(a => context.StaffAccounts.Add(a));
            await context.SaveChangesAsync();

            var Permissions = new List<Permission>
            {
                new Permission { PermissionID = 4}
            };
            Permissions.ForEach(p => context.Permissions.Add(p));
            await context.SaveChangesAsync();

            var PaymentDetails = new List<PaymentDetail>
            {
                new PaymentDetail { PaymentDetailsID = 4, AccountNumber = "0000 1111 2222 3333", SortCode = "001122"}
            };
            PaymentDetails.ForEach(p => context.PaymentDetails.Add(p));
            await context.SaveChangesAsync();
        }
    }
}
