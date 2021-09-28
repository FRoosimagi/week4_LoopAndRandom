using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku numbri;
            //kui genereeritud nr on 5, programm lõpetab oma töö ja soovib "kena päeva";
            //kui genereeritud nr on midagi muud, siis programm jätkab tööd.

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11); 
                Console.WriteLine($"Juhuslik nr on {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }

            }

            Console.WriteLine("kena päeva!");
            

           
        }
    }
}
