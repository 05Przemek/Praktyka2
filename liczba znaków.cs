using System;

namespace LiczbaZnakow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz coś");
            string input = Console.ReadLine();
            int liczbaZnakow = input.Length;

            Console.WriteLine("Liczba znaków w tym wierszu:" + liczbaZnakow);
        }
	}
}
