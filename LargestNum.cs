using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class LargestNum
    {
        public static void checkLargestAmongThree()
        {
            //taking user input numbers
            Console.WriteLine("Enter Number 1 : ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 3 : ");
            int number3 = int.Parse(Console.ReadLine());

            // implementation
            if ( number1 > number2 && number1 > number3)
            {
                Console.WriteLine(" number 1 is largest.");
            }
            else if( number2 > number3)
            {
                Console.WriteLine(" Number 2 is largest.");
            }
            else
            {
                Console.WriteLine(" Number 3 is Largest.");
            }
        }
    }
}
