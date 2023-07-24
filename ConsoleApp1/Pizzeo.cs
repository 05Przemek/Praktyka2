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

            double polePizzy1ZaZlotowke;
            double polePizzy2ZaZlotowke;

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

            polePizzy1ZaZlotowke = PolePizzyZaZlotowke(polePizzy1, cenaPizzy1);
            polePizzy2ZaZlotowke = PolePizzyZaZlotowke(polePizzy2, cenaPizzy2);

            Console.WriteLine($"Za 1 zł otrzymasz {polePizzy1ZaZlotowke:F2} cm^2 pizzy 1.");
            Console.WriteLine($"             oraz {polePizzy2ZaZlotowke:F2} cm^2 pizzy 2.");

            if(polePizzy1ZaZlotowke > polePizzy2ZaZlotowke)
            {
                Console.WriteLine("Pizza 1 bardziej się opłaca");
            }
            else if (polePizzy1ZaZlotowke < polePizzy2ZaZlotowke)
            {
                Console.WriteLine("Pizza 2 bardziej się opłaca");
            }
            else
            {
                Console.WriteLine("Obie pizze są równie opłacalne");
            }
            Console.ReadKey();
        }
        static double PoleKola(double promien)
        {
            return Math.PI * promien * promien;
        }
        static double PolePizzy (int srednica)
        {
            return PoleKola(srednica / 2.0);
        }
        static double PolePizzyZaZlotowke(double polePizzy, decimal cenaPizzy)
        {
            return polePizzy / (double)cenaPizzy;
        }
	}
}
