using EShop.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop.Models
{
    public class ClientOrder
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public float TotalInvoice { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string User_Id { get; set; }

        }
}