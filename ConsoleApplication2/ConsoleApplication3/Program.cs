using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cont = 1; cont <= 99; cont++)
            {
                Console.Write("Iniciando contador de 1 a 99!");
                Console.Write("\nContando: " + cont);
                Thread.Sleep(1000);

                if (cont != 99)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Write("\nFim da Contagem, pressione qualquer tecla para encerrar.");
                }

            }

            Console.ReadKey();

        }
    }
}