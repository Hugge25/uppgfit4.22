using System;

namespace Uppgfit4._22
{
    class Program
    {
        static void Main(string[]args)
        {
            for(int i = 10; i <=30; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
            for(int j = 200; j >= 180; j--)
            {
                Console.WriteLine(j);
                Thread.Sleep(100);
            }
            for (int y = 1000; y <= 1400; y+=50)
            {
                Console.WriteLine(y);
                Thread.Sleep(100);
            }
        }
    }
}