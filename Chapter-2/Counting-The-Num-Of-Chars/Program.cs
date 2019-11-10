using System;

namespace Counting_The_Num_Of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a word and be prepared to be amazed!");
            string myInput = Console.ReadLine(); 
            int charLength = myInput.Length;

            while (charLength == 0)
            {
                Console.WriteLine("We aint playing games here... put in some text!");
                myInput = Console.ReadLine(); 
                charLength = myInput.Length;
            }

            Console.WriteLine("Hi, you picked: '{0}' it has {1} chars in it! MIND BLOWN!?", myInput, charLength);
        }
    }
}
