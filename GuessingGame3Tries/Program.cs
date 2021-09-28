using System;

namespace GuessingGame3Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri (1-10);
            //kasutaja arvab numbri;
            //kui kasutaja arvab ära numbri, siis on ta võitnud;
            //katsete arv 3, kui kasutaja ei arva ära nr, siis mängu võidab arvuti;
            //programm genereerib juhusliku numbri ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;


            while (i < 3)
            {
                Console.WriteLine("Mis numbrile mõtleb arvuti:");
                int mynumber = Convert.ToInt32(Console.ReadLine());

                if(cpuNumber == mynumber)
                {
                    Console.WriteLine($"Õige, arvuti number oli {cpuNumber}");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale, järele on jäänud {3-i} katset");
                }
            }

            if(i > 2)
            {
                Console.WriteLine("Arvuti võitis!");
            }
            else
            {
                Console.WriteLine("Oled võitnud!");
            }
        }
    }
}
