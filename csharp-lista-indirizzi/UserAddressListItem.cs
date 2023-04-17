using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class UserAddressListItem
    {
        public User user { get; set; }
   
        public Address address { get; set; }

        public static int rowCount = 0;


    public UserAddressListItem(string[] paramsList)
        {
            user = new User(paramsList[((int)(ClassRequiredParams.Name))], paramsList[((int)(ClassRequiredParams.Surname))]);
            address = new Address(paramsList[((int)(ClassRequiredParams.Street))], paramsList[((int)(ClassRequiredParams.City))], paramsList[((int)(ClassRequiredParams.Province))], Convert.ToInt32(paramsList[((int)(ClassRequiredParams.ZIP))]));
            rowCount++;
        }


        public UserAddressListItem(string _name, string _surname, string _street, string _city, string _province, int _ZIP)
        {
            user = new User(_name, _surname);
            address = new Address(_street, _city, _province, _ZIP);
        }
    }

}
