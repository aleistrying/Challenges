using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ChallengesLearn ⌄ProfileMembershipOrganizations

            Tags: recursion, math fundamentals | Difficulty: Easy
            Challenge
            Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it. For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. For the test cases, the range will be between 1 and 18 and the input will always be an integer. 
            Sample Test Cases
            Input:4

            Output:24


            Input:8

            Output:40320
             */
            while (true)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine(userInput + "! = " + Fact(int.Parse(userInput)));
            }
        }
        private static int Fact(int number)
        {
            //int tempNum = 0;
            if (number == 1 || number == 0)
            {
                return number;
            }
            return number * Fact(number - 1);
        }
    }
}
