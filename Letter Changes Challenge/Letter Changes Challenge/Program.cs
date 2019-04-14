using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Changes_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Have the function LetterChanges(str) take the str parameter being passed
                and modify it using the following algorithm. Replace every letter in the
                string with the letter following it in the alphabet (ie. c becomes d, z 
                becomes a). Then capitalize every vowel in this new string (a, e, i, o, 
                u) and finally return this modified string. 
                Sample Test Cases
                Input:"hello*3"

                Output:"Ifmmp*3"


                Input:"fun times!"

                Output:"gvO Ujnft!"
             */
            while (true)
            { 
            string stringInput = Console.ReadLine();
            Console.WriteLine(LetterChanges(stringInput, 2));
            }
        }
        static string LetterChanges(string str, int repeats = 1)
        {
            string finalString = "";

            for (int i = 0; i <= repeats - 1; i++)
            {
                finalString = "";
                char[] charArray = str.ToCharArray();
                for (int k = 0; k < charArray.Count(); k++)
                {
                    finalString += ChangeAlphabet(charArray[k]);
                }
                str = finalString;
               

            }
            return finalString;

        }
        static char ChangeAlphabet(char character)
        {
            switch (character)
            {
                case 'a':
                    return 'b';
                    break;
                case 'A':
                    return 'B';
                    break;
                case 'b':
                    return 'c';
                    break;
                case 'B':
                    return 'C';
                    break;
                case 'c':
                    return 'd';
                    break;
                case 'C':
                    return 'D';
                    break;
                case 'd':
                    return 'e';
                    break;
                case 'D':
                    return 'E';
                    break;
                case 'e':
                    return 'f';
                    break;
                case 'E':
                    return 'F';
                    break;
                case 'f':
                    return 'g';
                    break;
                case 'F':
                    return 'G';
                    break;
                case 'g':
                    return 'h';
                    break;
                case 'G':
                    return 'H';
                    break;
                case 'h':
                    return 'i';
                    break;
                case 'H':
                    return 'I';
                    break;
                case 'i':
                    return 'j';
                    break;
                case 'I':
                    return 'J';
                    break;
                case 'j':
                    return 'k';
                    break;
                case 'J':
                    return 'K';
                    break;
                case 'k':
                    return 'l';
                    break;
                case 'K':
                    return 'L';
                    break;
                case 'l':
                    return 'm';
                    break;
                case 'L':
                    return 'M';
                    break;
                case 'm':
                    return 'n';
                    break;
                case 'M':
                    return 'N';
                    break;
                case 'n':
                    return 'o';
                    break;
                case 'N':
                    return 'O';
                    break;
                case 'o':
                    return 'p';
                    break;
                case 'O':
                    return 'P';
                    break;
                case 'p':
                    return 'q';
                    break;
                case 'P':
                    return 'Q';
                    break;
                case 'q':
                    return 'r';
                    break;
                case 'Q':
                    return 'R';
                    break;
                case 'r':
                    return 's';
                    break;
                case 'R':
                    return 'S';
                    break;
                case 's':
                    return 't';
                    break;
                case 'S':
                    return 'T';
                    break;
                case 't':
                    return 'u';
                    break;
                case 'T':
                    return 'U';
                    break;
                case 'u':
                    return 'v';
                    break;
                case 'U':
                    return 'V';
                    break;
                case 'v':
                    return 'w';
                    break;
                case 'V':
                    return 'W';
                    break;
                case 'w':
                    return 'x';
                    break;
                case 'W':
                    return 'X';
                    break;
                case 'x':
                    return 'y';
                    break;
                case 'X':
                    return 'Y';
                    break;
                case 'y':
                    return 'z';
                    break;
                case 'Y':
                    return 'Z';
                    break;
                case 'z':
                    return 'a';
                    break;
                case 'Z':
                    return 'A';
                    break;
                default:
                    return character;
                    break;
            }
            //return character;
        }
    }
}
