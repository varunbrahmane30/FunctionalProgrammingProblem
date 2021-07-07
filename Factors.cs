using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class Factors
    {
        public static void calFactors()
        {
            //taking user  input 
            Console.WriteLine("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            //implementation
            while (number % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                number /= 2;
            }

            
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
               
                while (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                    number /= i;
                }
            }

           

            if (number > 2)
                Console.WriteLine(number);
        }
    }
}

