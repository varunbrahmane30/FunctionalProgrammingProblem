using System;
using System.Collections.Generic;
using System.Text;

namespace D5BasicPrograms
{
    class VowelOrConst
    {
        public static void checkVowelOrConst()
        {
            //variables 


            //taking user input for alphabet 
            Console.WriteLine("Enter Alphabet to Check : ");
            char value = char.Parse(Console.ReadLine());

            // implementation 
            if ( value == 'a' || value == 'A' || value == 'e' || value == 'E' || value == 'i' || value == 'I' || value == 'o' || value == 'O' || value == 'u' || value == 'U')
            {
                Console.WriteLine("Albhabet " + value + " is Vowel. ");
            }
            else
            {
                Console.WriteLine( "Albhabet " + value + " is Constant. ");
            }
        }
    }
}
