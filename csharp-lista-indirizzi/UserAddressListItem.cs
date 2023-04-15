using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class UserAddressListItem
    {
        private User user;
        private Address address;


        public UserAddressListItem(string[] paramsList)
        {
            user = new User(paramsList[0], paramsList[1]);
            address = new Address(paramsList[2], paramsList[3], paramsList[4], Convert.ToInt16(paramsList[5])) ;
        }


        public UserAddressListItem(string _name, string _surname, string _street, string _city, string _province, int _ZIP)
        {
           user = new User(_name, _surname);
           address = new Address(_street,_city,_province,_ZIP);
        }
    }
}
