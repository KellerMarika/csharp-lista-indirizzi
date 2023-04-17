using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public Int32 ZIP { get; set; }

        public Address(string _street, string _city, string _province, int _ZIP)
        {
            Street = _street;
            City = _city;
            Province = _province;
            ZIP = _ZIP;
        }

    }
}
