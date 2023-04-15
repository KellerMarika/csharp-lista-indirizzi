using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public  static class Utilities
    {
        public static List <string[]> getListFromFile(this string path, bool ignoreFirstLine, char separator = ',')
        {

            List<string[]> rowArrayList = new List<string[]>();
            var addressesFile = File.OpenText(path);
            int i=0;
            while (!addressesFile.EndOfStream)
            {

                //Console.WriteLine(addressesFile.ReadLine());
                //Console.WriteLine( File.ReadLines(path).First());
                //Console.WriteLine(addressesFile.ReadLine() == File.ReadLines(path).First());
                if (ignoreFirstLine && i++ == 0) continue;

                string fileRow = addressesFile.ReadLine();
                var classParamsToControl_list = fileRow.Split(separator);//array


//                ValidationRules.ValidateArrayParams1(classParamsToControl_list,6);
                ValidationRules.ValidateArrayParams(classParamsToControl_list, rowArrayList);

                //rowArrayList.Add(classParamsToControl_list);

               // rowArrayList.Add(ValidationRules.ValidateArrayParams(classParamsToControl_list));
            }
            return rowArrayList;
        }


    }
}
