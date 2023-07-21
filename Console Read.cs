using System;

namespace Skip
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Podaj imie");
			string Imieuzytkownika = Console.ReadLine();


			Console.Clear();
			Console.WriteLine($"Witaj {Imieuzytkownika} !");
		}
	}
}
