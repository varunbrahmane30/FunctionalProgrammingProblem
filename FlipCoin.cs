using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class FlipCoin
    {
        public static void checkFlipCoin()
        {
            // generating random 
            Random random =new Random();
            int value = random.Next(0,2);

            //variables declaration
            int percentageTail = 0;
            int percentageHead = 0;

            
            // implementation 
            if( value < 0.5)
            {
               // Console.WriteLine("Tails");
                percentageTail++;
            }
            else
            {
               // Console.WriteLine("Heads");
                percentageHead++;
            }

            // result display on console 
            Console.WriteLine("Percentage of head is : " + percentageHead);
            Console.WriteLine("Percentage of Tail is : " + percentageTail);



        }
    }
}
