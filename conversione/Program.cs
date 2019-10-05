using System;

namespace conversione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il numero da convertire:");
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine($"il corrispettivo numero binario è {binary}");
            Console.ReadLine();
        }
    }
}
