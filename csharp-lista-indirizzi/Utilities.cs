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
            int i=0;
            var addressesFile = File.OpenText(path);
            while (!addressesFile.EndOfStream)
            {
                if (ignoreFirstLine && i++ == 0) continue;
                string fileRow = addressesFile.ReadLine();
                Console.Write(fileRow); 
                var classParamsToControl_list = fileRow.Split(separator);//array
                ValidationRules.ValidateArrayParams(classParamsToControl_list, rowArrayList);
            }
            return rowArrayList;
        }


    }
}
