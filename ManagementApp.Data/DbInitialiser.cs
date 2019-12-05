using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.Data
{
    public static class DbInitialiser
    {
        public static async Task SeedTestData(Db context,
                                             IServiceProvider services)
        {
            if (context.StaffAccounts.Any())
            {
                return;
            }

            var Permissions = new List<Permission>
            {
                new Permission { Name = "Test"}
            };
            Permissions.ForEach(p => context.Permissions.Add(p));
            await context.SaveChangesAsync();

            var StaffAccounts = new List<StaffAccount>
            {
                new StaffAccount { StaffID = 42, Name = "Jordan", PermissionID = 1}
            };
            StaffAccounts.ForEach(a => context.StaffAccounts.Add(a));
            try { await context.SaveChangesAsync();
            } catch(Exception ex) {
                ex.ToString();
            }

            var PaymentDetails = new List<PaymentDetail>
            {
                new PaymentDetail { PaymentDetailsID = 4, AccountNumber = "0000 1111 2222 3333", SortCode = "001122"}
            };
            PaymentDetails.ForEach(p => context.PaymentDetails.Add(p));
            await context.SaveChangesAsync();

            var PurchaseRequests = new List<PurchaseRequest>
            {
                new PurchaseRequest {PurchaseRequestID = 1, StaffID = 42, VendorID = 1,
                    ProductName = "Test Product", ProductPrice = 20, ProductQty = 5, PaymentDetailsID =4}
            };
            PurchaseRequests.ForEach(r => context.PurchaseRequests.Add(r));
            await context.SaveChangesAsync();
        }
    }
}
