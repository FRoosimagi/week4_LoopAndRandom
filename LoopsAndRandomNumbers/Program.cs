using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvutiga 1234;
            //kui sisestatud PIN-kood on õige, kuvab konsool "tere tulemast";
            //kui PIN-kood on vale, kuvab konsool "Vale PIN, Proovi uuesti";
            //kasutajal on 3 katset.

            int i = 0;
            
            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");

                }

                Console.WriteLine("Kena päeva!");
                
                
            } 

            

            


        }
    }
}
