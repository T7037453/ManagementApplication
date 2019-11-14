using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Data
{
    class PurchaseRequest
    {
        public int PurchaseRequestID { get; set; }
        public int StaffID { get; set; }
        public int VendorID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set;}
        public int ProductQty { get; set; }
        public int PaymentDetailsID { get; set; }
        // Maybe have ability to add card details, then select them from drop down when approving.
        public PaymentDetails Payment { get; set: }
    }
}
