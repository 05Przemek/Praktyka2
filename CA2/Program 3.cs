using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main()
        {
            int x = 7; 
            int y;
            y = F(x);
        }
        static int F(int x)
        {
            int y = x + 13;
            return y;
        }
    }
}
