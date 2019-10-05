using System;

namespace conversione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il numero da convertire:");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("qualee base convertire? binaria/ottale/esadecimale");
            string ris = Console.ReadLine();
            double risultato = 0;
            switch (ris)
            {
                case "binario":
                    string binary = Convert.ToString(value, 2);
                    Console.WriteLine($"il corrispettivo numero binario è {binary}");
                    break;
            }






            string binary = Convert.ToString(value, 2);
            Console.WriteLine($"il corrispettivo numero binario è {binary}");
            string esadecimale = Convert.ToString(value, 16);
            Console.WriteLine($"il corrispettivo numero esadecimale è {esadecimale}");
            string ottale = Convert.ToString(value, 8);
            Console.WriteLine($"il corrispettivo numero binario è {ottale}");
            Console.ReadLine();

        }
    }
}
