using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class BillForService
    {
        public int IdBillForServices { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? ClientId { get; set; }
        public int? TypeOfServicesId { get; set; }

    }
}
