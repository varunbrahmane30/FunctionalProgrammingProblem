using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class EvenOdd
    {
        public static void calEvenOdd()
        {
            // taking User input for number
            Console.WriteLine("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            
            if( (number % 2) == 0)
            {
                Console.WriteLine("Number is EVEN");
            }
            else
            {
                Console.WriteLine("NUmber is ODD");
            }
        }
    }
}
