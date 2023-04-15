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
    }
}