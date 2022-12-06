using System;

namespace lab2ex4
{
    /*  Scrieti un program care va determina daca 
        un numar este sau nu palindrom.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul : ");
         
            int number = int.Parse(Console.ReadLine());
            int numberTemp1 = number;
            int contor = 0;

            if (number < 10)
            {
                Console.Write("Introduceti un numar din cel putin doua cifre ");
                return;
            }

            while (numberTemp1 > 0)
            {

                numberTemp1 = numberTemp1 / 10;
                contor++;
            }

            int[] cifre = new int[contor];
             
            for (int i = 0; i < contor; i++)
            {
                cifre[i] = number % 10;  
                number = number / 10;    
            }

            for (int i = 0; i < contor / 2; i++)
            {
                
                if (cifre[i] != cifre[contor - i - 1 ])
                {
                    Console.WriteLine("Numarul nu este palindrom.");
                    return;
                }

            }

            Console.WriteLine("Numarul este palindrom.");


        }
    }
}
