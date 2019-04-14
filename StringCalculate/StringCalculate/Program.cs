using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculate
{
    class Program
    {
        private static string EliminateSpaces(string str)
        {
            string newStr = "";
            char[] charArray = str.ToCharArray();
            foreach(char c in charArray)
            {
                if (c != ' ')
                {
                    newStr = newStr + c;
                } 

            }
            return newStr;
        }
        private static float StringCalculate(string str)
        {
            
            long n = 0;
            float value = 0;
            string newStr = "";
            //Input:"6*(4/2)+3*1"
            //Output:"15"
            //Input:"100*2**4"
            //Output:"1600"
            string bracket = "";
            str = EliminateSpaces(str);
            char[] charArray = str.ToCharArray();
            //str = "";

            foreach (char c in charArray)
            {

                if (long.TryParse(c.ToString(), out long result) == true)
                {
                    newStr = newStr + result.ToString();
                    value = long.Parse(newStr);
                }
                else if (c == '/')
                {
                    //newStr = NumberFix(StringReverse(newStr));
                    //str = NumberFix(StringReverse(str));
                    char[] newStrCharArray = newStr.ToCharArray();

                    char[] charsDel = new char[newStrCharArray.Count() + 1];
                    for (int i = 0; i < charsDel.Count(); i++)
                    {
                        charsDel[i] = '0';
                    }
                    for (int i = 0; i < newStrCharArray.Count(); i++)
                    {
                        charsDel[i] = newStrCharArray[i];
                    }
                    //charsDel = newStrCharArray;
                    charsDel[charsDel.Count() - 1] = '/';
                    string tempStr = str;
                    for (int j = 0; j < charsDel.Count(); j++)
                    {
                        tempStr = tempStr.TrimStart(charsDel[j]);
                    }
                    //string tempStr = str.Trim(charsDel);
                    value = (float)float.Parse(newStr) / (float)StringCalculate(tempStr);
                    break;
                }
                else if (c == '*')
                {
                    //creates an chararray and adds an extra value to it
                    char[] newStrCharArray = newStr.ToCharArray();

                    char[] charsDel = new char[newStrCharArray.Count() + 1];
                    for (int i = 0; i < charsDel.Count(); i++)
                    {
                        charsDel[i] = '0';
                    }
                    for (int i = 0; i < newStrCharArray.Count(); i++)
                    {
                        charsDel[i] = newStrCharArray[i];
                    }
                    //charsDel = newStrCharArray;
                    charsDel[charsDel.Count() - 1] = '*';
                    string tempStr = str;
                    //for(int j = 0; j < charsDel.Count(); j++)
                    //{
                    //    tempStr = tempStr.TrimStart(charsDel[j]);
                    //}
                    string newTemp = str;
                    string tempNumberStr = "";
                    for(int j = Array.IndexOf(charArray, '*'); j < charArray.Count() -1; j++)
                    {
                        if (int.TryParse(charArray[j].ToString(),out int number) == true)
                        {
                            tempNumberStr = tempNumberStr + number.ToString();
                        }

                    }

                    //string tempStr = str.Trim(charsDel);
                    value =  StringCalculate(float.Parse(newStr) * tempStr);
                    break;
                    newStr = "";
                }
                else if (c == '-')
                {
                    //creates an chararray and adds an extra value to it
                    char[] newStrCharArray = newStr.ToCharArray();

                    char[] charsDel = new char[newStrCharArray.Count() + 1];
                    for (int i = 0; i < charsDel.Count(); i++)
                    {
                        charsDel[i] = '0';
                    }
                    for (int i = 0; i < newStrCharArray.Count(); i++)
                    {
                        charsDel[i] = newStrCharArray[i];
                    }
                    //charsDel = newStrCharArray;
                    charsDel[charsDel.Count() - 1] = '-';
                    string tempStr = str;
                    for (int j = 0; j < charsDel.Count(); j++)
                    {
                        tempStr = tempStr.TrimStart(charsDel[j]);
                    }
                    //string tempStr = str.Trim(charsDel);
                    value = float.Parse(newStr) * StringCalculate(tempStr);
                    break;
                    newStr = "";
                }
                else if (c == '+')
                {
                    //creates an chararray and adds an extra value to it
                    char[] newStrCharArray = newStr.ToCharArray();

                    char[] charsDel = new char[newStrCharArray.Count() + 1];
                    for (int i = 0; i < charsDel.Count(); i++)
                    {
                        charsDel[i] = '0';
                    }
                    for (int i = 0; i < newStrCharArray.Count(); i++)
                    {
                        charsDel[i] = newStrCharArray[i];
                    }
                    //charsDel = newStrCharArray;
                    charsDel[charsDel.Count() - 1] = '+';
                    string tempStr = str;
                    for (int j = 0; j < charsDel.Count(); j++)
                    {
                        tempStr = tempStr.TrimStart(charsDel[j]);
                    }
                    //string tempStr = str.Trim(charsDel);
                    value = float.Parse(newStr) + StringCalculate(tempStr);
                    break;
                    newStr = "";
                }
                
            }

            return value;

        }
        /// <summary>
        /// Reverses any string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringReverse(string str)
        {
            string finalString = "";
            char[] strChar = str.ToCharArray();
            //char[] reverseStrChar = new char[strChar.Length];
            for(int i = strChar.Length - 1; i >= 0; i--)
            {
                finalString = finalString + strChar[i];
            }
            return finalString;
        }
        /// <summary>
        /// Takes any string of numbers, and inverses it. without inversing their positions and signs.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NumberFix(string str)
        {
            string value = "";
            string finalString = "";
            char sign = ' ';
            char[] charArray = str.ToCharArray();
            char[] charsDel = null;
            for (int i = 0; i < charArray.Length; i++)
            {
                if(int.TryParse(charArray[i].ToString(),out int result) == true)
                {
                    value = value + result.ToString();
                }
                else if(charArray[i].ToString() == "+" || charArray[i].ToString() == "-" || charArray[i].ToString() == "/" || charArray[i].ToString() == "*")
                {
                    sign = charArray[i];
                    value = StringReverse(value);
                    charsDel = new char[value.Length+1];
                    for (int k = 0; k < charsDel.Count(); k++)
                    {
                        charsDel[k] = '0';
                    }
                    for (int k = 0; k < charsDel.Length; k++)
                    {
                        charsDel[k] = charArray[k];
                    }
                    string tempStr = str;
                    //charsDel[charsDel.Lenght - 1] = sign;
                    for (int k = 0; k < charsDel.Count(); k++)
                    {
                        tempStr = tempStr.TrimStart(charsDel[k]);
                    }
                    finalString = tempStr;
                    value = value + sign + NumberFix(finalString);
                    return value;
                }
                //else
                //{
                //}
            }
            value = StringReverse(value);

            return value;
        }
        public static void Main(string[] args)
        {
            string str = "";
            string userStr = "";
            while (userStr != "stop")
            {
                userStr = Console.ReadLine ();
                //userStr = " 1 0 * 1 0 ";
                //str = StringReverse(userStr);
                //str = NumberFix(userStr);
                str = StringCalculate(userStr).ToString();
                //str = EliminateSpaces(userStr);
                Console.WriteLine(str);
            }
            Console.WriteLine("Code end");
        }
    }
}
