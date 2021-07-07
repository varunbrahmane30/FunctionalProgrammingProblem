using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class SwapNumbers
    {
        public static void swappingNumbers()
        {
            // variables
            int temp;

            // taking User input for numbers
            Console.WriteLine("Enter Number 1 : ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(".... before swapping .... ");
            Console.WriteLine("Number 1 is :" + number1);
            Console.WriteLine("Number 2 is :" + number2);

            Console.WriteLine();

            // implementation

            temp = number1;
            number1 = number2;
            number2 = temp;

            // printing result of swapping 
            Console.WriteLine(".... After swapping .... ");
            Console.WriteLine("Number 1 is :" +number1);
            Console.WriteLine("Number 2 is :" +number2);



        }
    }
}
