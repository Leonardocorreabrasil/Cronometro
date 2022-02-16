using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()

        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            var time = int.Parse(data.Substring(0, data.Length - 1));
            var multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("ready...");
            Thread.Sleep(1000);
            Console.WriteLine("set...");
            Thread.Sleep(1000);
            Console.WriteLine("go...");
            Thread.Sleep(2500);

            Start(time);
        }


        static void Start(int time)
        {
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("stopwatch finalizado.... retornando para o menu");
            Thread.Sleep(2500);
            Menu();
        }
    }
}