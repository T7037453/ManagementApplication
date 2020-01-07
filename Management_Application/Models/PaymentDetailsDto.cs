using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Web.Models
{
    public class PaymentDetailsDto
    {
        public int Id { get; set; }
        public int PaymentDetailsID { get; set; }
        public string AccountNumber { get; set; }
        public string SortCode { get; set; }

    }
}
