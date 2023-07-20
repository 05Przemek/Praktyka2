using System;

namespace Typy tekstowe 
{
    class Program
    {
        static void Main()
        {
            string imie;

            imie = "Ania";
            int Nieprzeczytane = 7;
            int Powiadomienia = 9;

            string powitanie = Generujpowitanie(imie, Nieprzeczytane, Powiadomienia);
            
            Console.WriteLine($"Witaj {imie}! Masz {Nieprzeczytane} nieprzeczytanych wiadomości oraz {Powiadomienia} powiadomień.");
        }
        
        static string Generujpowitanie(string imie, int Nieprzeczytane, int Powiadomienia)
        {
            string output = $"Witaj {imie}! Masz {Nieprzeczytane} nieprzeczytanych wiadomości oraz {Powiadomienia} powiadomień.";
            return output ;
        }
    }
}