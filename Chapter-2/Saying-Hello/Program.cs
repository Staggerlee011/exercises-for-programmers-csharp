using System;
using System.Text.RegularExpressions;

namespace Saying_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
			Console.Write("Whats your name stranger?.. ");
			myInput = Console.ReadLine();  

            // teste if myInpuy is ALL numeric values ie 1, 23 
            if (Regex.IsMatch(myInput, @"^\d+$"))
            {
                Console.WriteLine("You are not a number!");
            } else {
                Console.WriteLine("Hi '{0}', nice to meet you!!!", myInput);
            }
        }
    }
}
