using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSymbolsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Challenge
            Have the function SimpleSymbols(str) take the str 
            parameter being passed and determine if it is an 
            acceptable sequence by either returning the string 
            true or false. The str parameter will be composed of 
            + and = symbols with several letters between them 
            (ie. ++d+===+c++==a) and for the string to be true each
            letter must be surrounded by a + symbol. So the string to 
            the left would be false. The string will not be empty and 
            will have at least one letter. 
            Sample Test Cases
            Input:"+d+=3=+s+"

            Output:"true"


            Input:"f++d+"

            Output:"false"
             */
            while (true)
            {
                //testing char numbers
                //Console.WriteLine((int)'a'); //97
                //Console.WriteLine((int)'z'); //122
                //Console.WriteLine((int)'A'); //65
                //Console.WriteLine((int)'Z'); //90

                try
                {
                    Console.WriteLine(SimpleSymbols(Console.ReadLine()));
                }
                catch
                {
                }
            }
        }
        static bool SimpleSymbols(string str)
        {
            string tempStr = "";
            char[] textChar = str.ToCharArray();
            bool flag = false;
            for(int i = 0; i < textChar.Count(); i++)
            {
                if(((int)textChar[i] >= 97 && (int)textChar[i] <= 122) || ((int)textChar[i] >= 65 && (int)textChar[i] <= 90)) 
                {
                    if (i != textChar.Count() - 1 && i != 0)
                    {
                        if (textChar[i - 1] == '+' && textChar[i + 1] == '+')
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            return flag;
                        }
                    }
                    else
                    {
                        flag = false;
                        return flag;
                    }
                }
            }


            return flag;
        }
    }
}
