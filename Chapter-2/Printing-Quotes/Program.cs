using System;

namespace Printing_Quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a quote");
            string quote = Console.ReadLine(); 
            int quoteLength = quote.Length;

            while (quoteLength == 0)
            {
                Console.WriteLine("Seriously just pick a quote!");
                quote = Console.ReadLine(); 
                quoteLength = quote.Length;
            }

            Console.WriteLine("Who said that?");
            string who = Console.ReadLine(); 
            int whoLength = who.Length;

            while (whoLength == 0)
            {
                Console.WriteLine("Come on.. who said it?");
                who = Console.ReadLine(); 
                whoLength = who.Length;
            }

            Console.WriteLine("{0} said \"{1}\"", who, quote);
        }
    }
}
