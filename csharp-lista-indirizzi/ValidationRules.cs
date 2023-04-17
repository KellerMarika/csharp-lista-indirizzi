using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public enum ClassRequiredParams
    { Name, Surname, Street, City, Province, ZIP }
    public class ValidationRules
    {
     
        public static void ValidateArrayParams(string[] paramsArray, List<string[]> validatedParamsList)
        {

            //for (int i = 0; i < paramsArray.Length; i++)
            //{
            //    Console.Write(paramsArray[i] + " ");
            //}
            Console.WriteLine(":   ");

            var ParamsCount = Enum.GetNames(typeof(ClassRequiredParams)).Length;

            string message;

            List<string[]> arrayWerePushValidated = validatedParamsList;
            switch (paramsArray.Length)
            {
                case var value when value > ParamsCount: 
                    message = " troppi dati inseriti!";
                    Console.WriteLine($"dati inseriti: {paramsArray.Length}/{ParamsCount}{message}  --- FAIL");
                    break;
                case var value when value < ParamsCount:
                    message = " dati mancanti!";
                    Console.WriteLine($"dati inseriti: {paramsArray.Length}/{ParamsCount}{message}  --- FAIL");
                    break;
                default:
                    message = " ";
                    Console.Write($"dati inseriti: {paramsArray.Length}/{ParamsCount}{message}");


                    if (Validatestring((paramsArray[((int)(ClassRequiredParams.Name))]), false, false, null, null))
                        if (Validatestring((paramsArray[((int)(ClassRequiredParams.Surname))]), false, false, null, null))
                            if (Validatestring((paramsArray[((int)(ClassRequiredParams.Street))]), false, false, null, null))
                                if (Validatestring((paramsArray[((int)(ClassRequiredParams.City))]), false, false, null, null))
                                    if (Validatestring((paramsArray[((int)(ClassRequiredParams.Province))]), false, false, 2, 2))
                                        if (Validatestring((paramsArray[((int)(ClassRequiredParams.ZIP))]), false, true, null, null))
                                        {
                                            arrayWerePushValidated.Add(paramsArray);
                                            Console.WriteLine("--- SUCCESS");
                                        }
               break;
            }
           
        }


        public static bool Validatestring (string paramToValidate, bool isEmpty, bool toInt, int? minNum,int? maxNum)
        {

            bool result = true;

            if (!isEmpty && string.IsNullOrWhiteSpace(paramToValidate))
            {
                Console.WriteLine($"'{paramToValidate}' non è un dato valido perchè vuoto  --- FAIL");
                result = false;
            }
            else if (minNum != null && paramToValidate.Length < minNum)
            {
                Console.WriteLine($"'{paramToValidate}' non è un dato valido perchè formato da - di {minNum} caratteri --- FAIL");
                result = false;
            }
            else if (maxNum != null && paramToValidate.Length > maxNum)
            {
                Console.WriteLine($"'{paramToValidate}' non è un dato valido perchè formato da + di {maxNum} caratteri --- FAIL");
                result = false;
            }
            else if (toInt)
            {

                //converte stringa in numero se non è convertibile restituisce 0
                int intValue = int.TryParse(paramToValidate, out intValue) ? intValue : 0;
                //converto il numero in booleano
                bool boolValue = Convert.ToBoolean(intValue);
                if (!boolValue)
                {
                    Console.WriteLine($"'{paramToValidate}' non è un dato valido perchè non è un numero --- FAIL");
                    result = false;
                }
            }
            return result;
        }

    } 
}
