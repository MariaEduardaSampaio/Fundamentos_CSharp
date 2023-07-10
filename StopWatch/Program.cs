using System;

namespace StopWatch
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
            Console.WriteLine("S = segundos => 10s = 10 segundos");
            Console.WriteLine("M = minutos => 4m = 4 minutos");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);
        }

        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                int currentMinute = currentTime / 60;
                int currentSeconds = currentTime - (currentMinute * 60);

                Console.WriteLine($"{currentMinute}m {currentSeconds}s");

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
            Menu();
        }
    }
}