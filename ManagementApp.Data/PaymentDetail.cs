using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Data
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public int PaymentDetailsID { get; set; }
        public string AccountNumber { get; set; }
        public string SortCode { get; set; }
    }
}
