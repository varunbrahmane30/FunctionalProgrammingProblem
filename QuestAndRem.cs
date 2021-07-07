using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class QuestAndRem
    {
        public static void calQuestAndRem()
        {
            // variables
            float quest = 0;
            float rem = 0;

            // taking input 
            Console.WriteLine("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter divident: ");
            int divident = int.Parse(Console.ReadLine());

            //operation 
            quest = divident / divisor;
            rem = divident % divisor;

            // print result on console
            Console.WriteLine("Questiont is : "+ quest);
            Console.WriteLine("Remainder is : " + rem);
        }
    }
}
