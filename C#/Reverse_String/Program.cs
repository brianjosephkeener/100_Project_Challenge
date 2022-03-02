using System;

/*

Category: Text

Reverse a String - Enter a string and the program will reverse it and print it out.
*/

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string to reverse now:\n");
            string input = Console.ReadLine();
            char[] chararr = input.ToCharArray();
            for (int i = chararr.Length-1; i >=0 ; i--)
            {
                Console.Write(chararr[i]);
            }
        }
    }
}
