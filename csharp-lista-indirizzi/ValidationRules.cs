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
        public static void ValidateArrayParams1(string[] arrayParam, int numParams)
        {  string message;
            switch (arrayParam.Length)
            {
                case var value when value < numParams: // that's the trick
                    message = "troppi dati inseriti!";
                    break;
                case var value when value > numParams: // that's the trick
                    message = "dati mancanti!";
                    break;
                default:
                    message = ",";
                    break;
            }
            Console.WriteLine($"dati inseriti: {arrayParam.Length}/6 {message}");
        }
        //controlli sull'array
       
        public static void ValidateArrayParams2(string[] paramsArray, int numParams, List<string[]>validatedParamsList )
        {
            //DAVIDE PERCHé QUESTO NON VA
            //int n = numParams;
            // string message = paramsArray.Length switch
            // {
            //    > n => "troppi dati inseriti",
            //    < n => "dati mancanti",
            //     _ => "tu puoi passare"
            // };

            //MA QUESTO SI?!?!?!
            //string message1 = paramsArray.Length switch
            //{
            //    > 6 => "troppi dati inseriti",
            //    < 6 => "dati mancanti",
            //    _ => "tu puoi passare"
            //};
            string message;
            List<string[]> arrayWerePushValidated = validatedParamsList;
            switch (paramsArray.Length)
            {
                case var value when value > numParams: // that's the trick
                    message = " troppi dati inseriti!";
                    break;
                case var value when value < numParams: // that's the trick
                    message = " dati mancanti!";
                    break;
                default:
                    message = ", ";


                    // controllo sui sigoli valori();//deve ritornare true
                    //if(controllo sui valori di array ritorna true ) validatedParamsLIst.add(arrayParams)
                    arrayWerePushValidated.Add(paramsArray);

                    break;
            }
            Console.WriteLine($"dati inseriti: {paramsArray.Length}/6{message}");
        }

        public static void ValidateArrayParams(string[] paramsArray, List<string[]> validatedParamsList)
        {
            var ParamsCount = Enum.GetNames(typeof(ClassRequiredParams)).Length;
            string message;
            List<string[]> arrayWerePushValidated = validatedParamsList;
            switch (paramsArray.Length)
            {
                case var value when value > ParamsCount: 
                    message = " troppi dati inseriti!";
                    break;
                case var value when value < ParamsCount:
                    message = " dati mancanti!";
                    break;
                default:
                    message = ", ";


                    // controllo sui sigoli valori();//deve ritornare true
                    //if(controllo sui valori di array ritorna true ) validatedParamsLIst.add(arrayParams)
                    arrayWerePushValidated.Add(paramsArray);

                    for (int i = 0; i < ParamsCount; i++) {


                        //                                char[]?,                                                          requiredChars
                       

                        //switch (arrayParam.Length)
                        //{
                        //    case var value when value < numParams: // that's the trick
                        //        message = "troppi dati inseriti!";
                        //        break;
                        //    case var value when value > numParams: // that's the trick
                        //        message = "dati mancanti!";
                        //        break;
                        //    default:
                        //        message = ",";
                        //        break;
                        //}

                        ValidateString(Func<string, bool, bool, int?, int?, bool> (params) filter , bool x);
                    
                    
                    
                    }
                    break;
            }
            Console.WriteLine($"dati inseriti: {paramsArray.Length}/{ParamsCount}{message}");
        }



        //STRING
        public static bool ValidateString(Func<string, bool, bool, int?, int?, bool> filter, bool x)
        {
                      return  x= filter("string", true, true, null, 1);
        }

        //funzione magica a cui passo una stringa e mi restituisce se per i parametri richiesti è validata o no (booleano)
        //                                char[]?,                                                          requiredChars
        Func<string, bool, bool, int?, int?, bool> filter = (paramToValidate, isEmpty, toInt, minNum, maxNum) =>
        {
            bool result = true;

            if (!isEmpty && string.IsNullOrWhiteSpace(paramToValidate))
            {
                Console.WriteLine($"{paramToValidate} non è un dato valido perchè vuoto");
                result = false;
            }
            if (minNum != null && paramToValidate.Length < minNum)
            {
                Console.WriteLine($"{paramToValidate} non è un dato valido perchè formato da - di {minNum} caratteri");
                result = false;
            }
            if (maxNum != null && paramToValidate.Length > maxNum)
            {
                Console.WriteLine($"{paramToValidate} non è un dato valido perchè formato da  di {maxNum} caratteri");
                result = false;
            }
            if (toInt)
            {
                Console.WriteLine(paramToValidate.GetType());

                //converte stringa in numero se non è convertibile restituisce 0
                int intValue = int.TryParse(paramToValidate, out intValue) ? intValue : 0;
                //converto il numero in booleano
                bool boolValue = Convert.ToBoolean(intValue);
                if (!boolValue)
                {

                    Console.WriteLine(boolValue);
                    //   Console.WriteLine(boolValue.GetType());
                    Console.WriteLine($"{paramToValidate} non è un dato valido perchè non è un numero");
                    result = false;
                }
            }

            return result;
        };

    } 
}
