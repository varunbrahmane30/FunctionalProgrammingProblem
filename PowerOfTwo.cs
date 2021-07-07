using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class PowerOfTwo
    {
        public static void powerOfTwo()
        {
            Console.WriteLine("Enter Number : ");
            int number = int.Parse(Console.ReadLine());
            
            for(int i=1;i<=number;i++)
            {
                Console.WriteLine(2*i);
            }
        }
    }
}
