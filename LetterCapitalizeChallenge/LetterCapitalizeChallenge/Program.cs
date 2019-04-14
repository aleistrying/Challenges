using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCapitalizeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ChallengesLearn ⌄ProfileMembershipOrganizations

                Tags: string manipulation | Difficulty: Easy
                Challenge
                Have the function LetterCapitalize(str) take the str parameter
                being passed and capitalize the first letter of each word. Words
                will be separated by only one space. 
                Sample Test Cases
                Input:"hello world"

                Output:"Hello World"


                Input:"i ran there"

                Output:"I Ran There"
            */
            while (true)
            {
                try
                {
                    Console.WriteLine(LetterCapitalize(Console.ReadLine()));
                }
                catch
                {
                }
            }
        }
        static string LetterCapitalize(string str)
        {
            char[] tempChar = str.ToCharArray();
            str = "";
            //string newSent = "";
            tempChar[0] = char.ToUpper(tempChar[0]);
            for (int i = 0; i <= tempChar.Count()-1; i++)
            {
                if(tempChar[i] == ' ')
                {
                    tempChar[i + 1] = char.ToUpper(tempChar[i + 1]);
                }
                str += tempChar[i];
            }
            return str;
        }
    }
}
