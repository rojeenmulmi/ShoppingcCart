using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectInvoice.Models
{
    public class CustomerDetails
    {
        public int CustomerDetailsID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public int phone { get; set; }
        public int cardnumber { get; set; }
        public int expirationdate { get; set; }
    }
}
