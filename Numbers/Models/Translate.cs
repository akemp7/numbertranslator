using System.Collections.Generic;
using System;

namespace NumberTranslate.Models
{
    public class Translate
    {
        public string Number { get; set; }
        public string StringOutput { get; set; }

        public Dictionary<char, string> onesDictionary = new Dictionary<char, string>() { {'0', "zero"}, {'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"} };
        public Dictionary<char, string> tensDictionary = new Dictionary<char, string>() { {'0', ""}, {'1', ""}, {'2', "twenty"}, {'3', "thirty"}, {'4', "forty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"} };

        public Translate (string number)
        {
            Number = number;
            StringOutput = "";
        }

        public void ConvertNumber()
        {
            char[] numberArray = Number.ToCharArray();
            string[] wordsArray = new string[numberArray.Length];


            if (numberArray.Length == 1)
            {
                wordsArray[0] = onesDictionary[numberArray[0]];
            }
            else if (numberArray.Length == 2)
            {
                if (numberArray[0] == '1')
                {
                    if (numberArray[1] == '0')
                    {
                        wordsArray[0] = "ten";
                    }
                    else if (numberArray[1] == '1')
                    {
                        wordsArray[0] = "eleven";
                    }
                    else if (numberArray[1] == '2')
                    {
                        wordsArray[0] = "twelve";
                    }
                    else if (numberArray[1] == '3')
                    {
                        wordsArray[0] = "thirteen";
                    }
                    else if (numberArray[1] == '5')
                    {
                        wordsArray[0] = "fifteen";
                    }
                    else if (numberArray[1] == '8')
                    {
                        wordsArray[0] = "eighteen";
                    }
                    else
                    {
                        wordsArray[0] = onesDictionary[numberArray[1]] + "teen";
                    }
                }
                else
                {
                    wordsArray[0] = tensDictionary[numberArray[0]];
                    wordsArray[1] = onesDictionary[numberArray[1]];
                }
            }
            
            StringOutput = string.Join(" ", wordsArray);
            Console.WriteLine(StringOutput);
        }
    }
}