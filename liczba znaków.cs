using System;

namespace LiczbaZnakow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz coś");
            string input = Console.ReadLine();
            
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Nie wpisałeś nic. -_-");
            }
            else
            {
                int liczbaZnakow = input.Length;
                Console.WriteLine("Liczba znaków w tym wierszu: " + liczbaZnakow);
            }
        }
	}
}
