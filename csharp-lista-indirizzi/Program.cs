﻿namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string a = "a231";
            //Console.WriteLine(a);
            //Console.WriteLine(a.GetType());


            ////converte stringa in numero se non è convertibile restituisce 0
            //int intValue = int.TryParse(a, out intValue) ? intValue : 0;
      
            //bool boolValue= Convert.ToBoolean(intValue);
            //Console.WriteLine(boolValue);
            //Console.WriteLine(boolValue.GetType());
       
            List<UserAddressListItem> UsersAddressesList = new List<UserAddressListItem>();

            string filePath = "C:\\Users\\marika\\EXPERIS_projects\\csharp-lista-indirizzi\\addresses.CSV";
            List<string[]> rowUsAdArraysOfParams = filePath.getListFromFile(true);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("elementi del file idonei ad essere integrati nella lista: "+rowUsAdArraysOfParams.Count);

            
            foreach (var item in rowUsAdArraysOfParams)
            {
                UsersAddressesList.Add(new UserAddressListItem(item));
            }

            Console.WriteLine( "elementi salvati in lista:"+   UserAddressListItem.rowCount);


            foreach (var row in UsersAddressesList)
            {
               Console.WriteLine(row.user.Name);
                Console.WriteLine(row.user.Surname);
                Console.WriteLine(row.address.Street);
                Console.WriteLine(row.address.City);
                Console.WriteLine(row.address.Province);
                Console.WriteLine(row.address.ZIP);
                Console.WriteLine("::::::::::::::::::::::::::::::::");
            }
        }
    }
}