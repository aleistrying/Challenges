using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Have the function FirstReverse(str) take the str parameter being passed 
             * and return the string in reversed order. For example: if the input string
             * is "Hello World and Coders" then your program should return the string sredoC 
             * dna dlroW olleH. 
                Sample Test Cases
                Input:"coderbyte"

                Output:"etybredoc"


                Input:"I Love Code"

                Output:"edoC evoL I"
             */
            while (true)
            {
                string InputStr = Console.ReadLine();
                Console.WriteLine(Reverse(InputStr));
            }
        }
        private static string Reverse(string str)
        {
            char[] tempStr = str.ToCharArray();
            //char[] tempFinalStr = new char[tempStr.Count()];
            string finalStr = "";
            for (int i = tempStr.Count() - 1; i >= 0; i--)
            {
                finalStr = finalStr + tempStr[i].ToString();
            }
            return finalStr;

        }
    }
}
