using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class LeapYear
    {
        public static void calLeapYear()
        {
            // taking input 
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());

            // implementation 
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
            }

            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
            }
            
        }
    }
}
