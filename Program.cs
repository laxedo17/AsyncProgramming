using System;
using System.Threading;

namespace Async1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Demonstracion-1.A Programa ASyncrono.***");
            Metodo1();
            Metodo2();
            Console.WriteLine("Finalizando Main()");
            Console.ReadKey();
        }

        private static void Metodo1()
        {
            Console.WriteLine("Metodo1() comenzou.");
            // Unha tarefa grande
            Thread.Sleep(1000);
            Console.WriteLine("Metodo1() finalizou");
        }

        private static void Metodo2()
        {
            Console.WriteLine("Metodo2() comenzou.");
            // Unha tarefa pequena
            Thread.Sleep(100);
            Console.WriteLine("Metodo2() finalizou");
        }
    }
}
