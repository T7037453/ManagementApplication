using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Web.Models
{
    public class PermissionsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool ViewStock { get; set; }
        public bool CreatePurchaseRequest { get; set; }
        public bool ReSell { get; set; }
        public bool PendingInvoices { get; set; }
        public bool ViewOrders { get; set; }
        public bool PurchaseControl { get; set; }
        public bool ViewProfile { get; set; }
        public bool HideReview { get; set; }
        public bool DeleteCustomer { get; set; }
    }
}