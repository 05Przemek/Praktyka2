<<<<<<< HEAD
﻿using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Strona 1";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("uno");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Dos");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("tres");
            Console.ResetColor();
            Console.Write("Naciśnij dowolny przycisk, żeby przejść do następnej strony");
            Console.ReadKey();
            Console.Clear();
            Console.Title = "Druga strona";
            Console.Write("Linia 4");
            Console.WriteLine("Linia 5");
            Console.Write("Naciśnij dowolny przycisk, żeby zamknąć okno");
        }
    }
}
=======
﻿using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Strona 1";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("uno");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Dos");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("tres");
            Console.ResetColor();
            Console.Write("Naciśnij dowolny przycisk, żeby przejść do następnej strony");
            Console.ReadKey();
            Console.Clear();
            Console.Title = "Druga strona";
            Console.Write("Linia 4");
            Console.WriteLine("Linia 5");
            Console.Write("Naciśnij dowolny przycisk, żeby zamknąć okno");
        }
    }
}
>>>>>>> 2ef705f7f507b92a6ef3f22790795ba9808f7cc8
