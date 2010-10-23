﻿using System;
using System.Linq;
using System.Threading;

namespace NetPonto.Sorteio.ConsoleApp
{
    class Program
    {
        static string[] participantes =
            {
                "Ana Ribeiro", 
                "Pedro Silva", 
                "Ricardo Santos"
            };

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.Write("A sortear");

            // Olha o sorteio :)
            var r = new Random();

            participantes = participantes
                .OrderBy(p => r.Next(0, participantes.Length)) // Um
                .ToArray()
                .OrderBy(p => r.Next(0, participantes.Length)) // Dois
                .ToArray()
                .OrderBy(p => r.Next(0, participantes.Length)) // Três
                .ToArray();

            for (var i = 0; i < 20; i++)
            {
                // Suspense
                Console.Write(".");
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
            }

            // Pronto...
            Console.WriteLine();
            Console.WriteLine("E o ganhador(a) do sorteio é:");
            Console.WriteLine();
            Console.WriteLine(participantes.Last());

            Console.ReadLine();
        }
    }
}