using System;

namespace Pizzeo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pizzeo v.1\n");

            int srednicaPizzy1;
            int srednicaPizzy2;

            decimal cenaPizzy1;
            decimal cenaPizzy2;

            double polePizzy1;
            double polePizzy2;

            Console.Write("Podaj średnicę Pizzy 1: ");
            srednicaPizzy1 = int.Parse(Console.ReadLine());

            Console.Write("Podaj cenę Pizzy 1    : ");
            cenaPizzy1 = decimal.Parse(Console.ReadLine());

            Console.Write("Podaj średnicę Pizzy 2: ");
            srednicaPizzy2 = int.Parse(Console.ReadLine());

            Console.Write("Podaj cenę Pizzy 2    : ");
            cenaPizzy2 = decimal.Parse(Console.Read());

            polePizzy1 = PolePizzy(srednicaPizzy1);
            polePizzy2 = PolePizzy(srednicaPizzy2);
        }
        static double PoleKola(double promien)
        {
            return 3.14 * promien * promien;
        }
        static double PolePizzy (int srednica)
        {
            return PoleKola(srednica / 2.0);
        }
	}
}
