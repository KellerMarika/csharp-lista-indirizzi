namespace csharp_lista_indirizzi
{
    internal class Action_Func
    {
        static void Example(string[] args)
        {
            Action<string, int> miaAzione = (pippo, i) =>
            {
                Console.WriteLine(pippo);
                Console.WriteLine(i);
            };
            Func<string, string, int> miaFunzione = (pippo, i) =>
            {
                return 1;
            };
            Func<string, bool> filter = s =>
            {
                return true;
            };
            miaAzione("ad", 1);
            var num = miaFunzione("asd", "asd");
        }
        public static int UsaFunzioni(Func<string, string, int> funzione, int num)
        {
            return num += funzione("pippo", "pluto");
        }
        //STRING
        //public static bool ValidateString(Func<string, bool, bool, int?, int?, bool> filter, bool isValid)
        //{
        //              return  isValid= filter("string", true, true, null, 1);
        //}

        ////funzione magica a cui passo una stringa e mi restituisce se per i parametri richiesti è validata o no (booleano)
        ////                                char[]?,                                                          requiredChars
        //Func<string, bool, bool, int?, int?, bool> filter = (paramToValidate, isEmpty, toInt, minNum, maxNum) =>
        //{
        //    Console.WriteLine($"{paramToValidate}");
        //    bool result = true;

        //    if (!isEmpty && string.IsNullOrWhiteSpace(paramToValidate))
        //    {
        //        Console.WriteLine($"{paramToValidate} non è un dato valido perchè vuoto");
        //        result = false;

        //    }
        //    else if (minNum != null && paramToValidate.Length < minNum)
        //    {
        //        Console.WriteLine($"{paramToValidate} non è un dato valido perchè formato da - di {minNum} caratteri");
        //        result = false;
        //    }
        //    else if (maxNum != null && paramToValidate.Length > maxNum)
        //    {
        //        Console.WriteLine($"{paramToValidate} non è un dato valido perchè formato da + di {maxNum} caratteri");
        //        result = false;
        //    }
        //    else if (toInt)
        //    {
        //        Console.WriteLine(paramToValidate.GetType());

        //        //converte stringa in numero se non è convertibile restituisce 0
        //        int intValue = int.TryParse(paramToValidate, out intValue) ? intValue : 0;
        //        //converto il numero in booleano
        //        bool boolValue = Convert.ToBoolean(intValue);
        //     if (!boolValue)
        //        {
        //            Console.WriteLine(boolValue);
        //            //   Console.WriteLine(boolValue.GetType());
        //            Console.WriteLine($"{paramToValidate} non è un dato valido perchè non è un numero");
        //            result = false;
        //        }
        //    }else
        //        Console.WriteLine($"{paramToValidate} validato CORRETTAMENTE!");

        //    return result;
        //};
    }
}