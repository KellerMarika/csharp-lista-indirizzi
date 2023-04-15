namespace csharp_lista_indirizzi
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
       
            List<Address> UsersAddressesList = new List<Address>();

            string filePath = "C:\\Users\\marika\\EXPERIS_projects\\csharp-lista-indirizzi\\addresses.CSV";
            List<string[]> rowUsAdArraysOfParams = filePath.getListFromFile(false);

            Console.WriteLine(rowUsAdArraysOfParams.Count);

            foreach (string[] row in rowUsAdArraysOfParams)
            {
            //    ValidationRules.ValidateArrayParams(row);
              //  Console.WriteLine(row);
            }
        }
    }
}