using System;

namespace Bendras_projektas
{
    class Program
    {
        static void Main(string[] args)
        {
            int spindulys = 6371;
            double plotas = 3.14 * Math.Pow(2, spindulys);
            Console.WriteLine($plotas);

            int spindulys2 = 6371;
            double rutulioTuris = 1.3 * 3.14 * Math.Pow(3, spindulys2);
            Console.WriteLine(rutulioTuris);


        }
    }
}