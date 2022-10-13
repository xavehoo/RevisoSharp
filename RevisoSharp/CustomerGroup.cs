using System;
using System.Collections.Generic;
using System.Text;

namespace RevisoSharp
{
    class CustomerGroup
    {
        public Account Account { get; set; }
        public long CustomerGroupNumber { get; set; }
        public Customer Customers { get; set; }
        public string Name { get; set; }
        public NumberSerie SalesInvoiceNumberSerie { get; set; }
    }
}
