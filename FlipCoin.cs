using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class FlipCoin
    {
        public static void checkFlipCoin()
        {

            //variables declaration
            int tail = 0;
            int head = 0;
            int flip;
            int totalIteration = 0;

            // Taking User Input

            Console.WriteLine("Enter how many times you want to Flip a Coin : ");
            flip = int.Parse(Console.ReadLine());


            // implementation 

                while (totalIteration <= flip)
                {
                    totalIteration++;


                // generating random 

                Random random = new Random();
                int value = random.Next(0, 2);

                // implementation 
                if (value < 0.5)
                {
                     Console.WriteLine("Tails");
                    tail++;
                }
                else
                {
                     Console.WriteLine("Heads");
                    head++;
                }


            }

            Console.WriteLine(head);
            Console.WriteLine(tail);


            // result display on console
                
            double headPerResult = head * 100 / flip;
            Console.WriteLine("Percentage of head is : " + headPerResult);

            double tailPerResult = tail * 100 / flip;
            Console.WriteLine("Percentage of Tail is : " + tailPerResult);

        }
    }
}
