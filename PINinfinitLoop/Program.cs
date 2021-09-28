using System;

namespace PINinfinitLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvutiga 1234;
            //kui sisestatud PIN-kood on õige, kuvab konsool "tere tulemast";
            //kui PIN-kood on vale, kuvab konsool "Vale PIN, Proovi uuesti";
            //katsete arv on piiramatu.

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN, proovi uuesti.");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud");
                }

                
            }
            
            Console.WriteLine("Kena päeva!");

        }
    }
}
