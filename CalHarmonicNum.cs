using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class CalHarmonicNum
    {
        public static void harmonicNum()
        {
            // taking user input 
            Console.WriteLine("Enter Harmonic Number N : ");
            double number = double.Parse(Console.ReadLine());

            //variable declaration
            double total=1;

            // implementation 
            for (int i = 2; i <= number; i++)
            {
                Console.WriteLine(total);
                total  += (double) 1 / i;
            }

            // printing result on Console.
            Console.WriteLine(" N'th Harmonic number value is : " + total);

        }
    }
}
