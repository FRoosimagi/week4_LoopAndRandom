using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri (1-10
            //kasutaja arvab numbri;
            //kui kasutaja arvab ära numbri, siis on ta võitnud;
            //katsete arv piiramatu;
            //programm genereerib juhusliku numbri ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool LoopActive = true;

            while (LoopActive) 
            {
                Console.WriteLine("Sisesta number:");
                int mynumber = Convert.ToInt32(Console.ReadLine());

                if(cpuNumber == mynumber)
                {
                    Console.WriteLine($"Õige, arvuti number oli {cpuNumber}");
                    LoopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale number, proovi uuesti");

                }

            }

            Console.WriteLine("Mäng läbi!");
        }
    }
}
