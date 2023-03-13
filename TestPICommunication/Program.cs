using System;
namespace TestPiCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }            
        }
    }
}