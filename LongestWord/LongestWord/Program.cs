using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Have the function LongestWord(sen) take the sen parameter being passed
             * and return the largest word in the string. If there are two or more words
             * that are the same length, return the first word from the string with that 
             * length. Ignore punctuation and assume sen will not be empty. 
                Sample Test Case[s
                Input:"fun&!! time"

                Output:"time"


                Input:"I love dogs"

                Output:"love"
            */
            while (true)
            {
                Console.WriteLine("Write the sentence you want the longest word searched for:");
                string strIn = Console.ReadLine();
                string output = "";
                output = LongestString(strIn);
                Console.WriteLine("the longest word is: " + output);
                Console.WriteLine();
                //Console.ReadLine();
            }

        }
        private List<string> Words = null;
        static int count = 0;
        static string LongestString(string strSentence)
        {
            count = 0;
            string longestWord = "";
            string currentWord = "";
            int averageWordLenght = (int)Math.Round((decimal)strSentence.Length / 5, 0);
            string[,] wordLenght = new string[averageWordLenght, 2];
            char[] Sentence = strSentence.ToCharArray();
            for (int i = 0; i < strSentence.Count(); i++)
            {
                if (CheckAlphabet(Sentence[i]) && Sentence[i] != ' ')
                {
                    currentWord = currentWord + Sentence[i];
                }
                else
                {
                    wordLenght[count, 0] = currentWord.Length.ToString();
                    wordLenght[count, 1] = currentWord;
                    count++;
                    currentWord = "";
                }
            }
            int longestValue = 0;
            //string tempLW;
            //bool repeatedValue = false;
            int parseValue = 0;
            //divide for 2 cuz it's a 2 d array.
            for (int i = 0; i < wordLenght.Length / 2; i++)
            {
                try
                {
                    parseValue = int.Parse(wordLenght[i, 0]);
                    if (parseValue >= longestValue)
                    {
                        //repeatedValue = false;
                        
                        if (parseValue != longestValue)
                        {
                            longestWord = wordLenght[i, 1];
                            longestValue = parseValue;
                        }
                        //if (parseValue == longestValue)
                        //{
                        //    repeatedValue = true;
                        //}
                    }
                }
                catch { }

            }
            //repeated module
            //if (!repeatedValue)
            //{
            //    longestWord = wordLenght[longestValue, 1];
            //}
            //else if (repeatedValue)
            //{
            // do reapeated stufff longestWord = found other words + and + longestword;
            //}
            //string[] tempArray = new string[wordLenght.Length / 2];

            //string[] tempArray2 = new string[wordLenght.Length / 2];
            //for (int i = 0; i < wordLenght.Length / 2; i++)
            //{

            //    //tempArray[i] = wordLenght[i, 0];
            //    tempArray2[i] = wordLenght[i, 1];
            //}

            //int indexOfWord = Array.IndexOf(tempArray, longestValue);
            //longestWord = tempArray2[indexOfWord];
            return longestWord;
        }
        static bool CheckAlphabet(char character)
        {
            bool tag = true;
            
            switch (character)
            {
                case '-':
                    break;
                case'\'':
                    break;
                case 'a':
                    break;
                case 'A':
                    break;
                case 'b':
                    break;
                case 'B':
                    break;
                case 'c':
                    break;
                case 'C':
                    break;
                case 'd':
                    break;
                case 'D':
                    break;
                case 'e':
                    break;
                case 'E':
                    break;
                case 'f':
                    break;
                case 'F':
                    break;
                case 'g':
                    break;
                case 'G':
                    break;
                case 'h':
                    break;
                case 'H':
                    break;
                case 'i':
                    break;
                case 'I':
                    break;
                case 'j':
                    break;
                case 'J':
                    break;
                case 'k':
                    break;
                case 'K':
                    break;
                case 'l':
                    break;
                case 'L':
                    break;
                case 'm':
                    break;
                case 'M':
                    break;
                case 'n':
                    break;
                case 'N':
                    break;
                case 'o':
                    break;
                case 'O':
                    break;
                case 'p':
                    break;
                case 'P':
                    break;
                case 'q':
                    break;
                case 'Q':
                    break;
                case 'r':
                    break;
                case 'R':
                    break;
                case 's':
                    break;
                case 'S':
                    break;
                case 't':
                    break;
                case 'T':
                    break;
                case 'u':
                    break;
                case 'U':
                    break;
                case 'v':
                    break;
                case 'V':
                    break;
                case 'w':
                    break;
                case 'W':
                    break;
                case 'x':
                    break;
                case 'X':
                    break;
                case 'y':
                    break;
                case 'Y':
                    break;
                case 'z':
                    break;
                case 'Z':
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;
                case '7':
                    break;
                case '8':
                    break;
                case '9':
                    break;
                default:
                    tag = false;
                    break;
            }
            return tag;
        }
    }
}
