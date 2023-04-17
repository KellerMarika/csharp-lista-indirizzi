using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string _name, string _surname)
        {
            Name = _name;
            Surname = _surname;
        }
    }
}
