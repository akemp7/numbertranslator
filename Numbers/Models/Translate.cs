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
         public Dictionary<char, string> hundredsDictionary = new Dictionary<char, string>() { {'0', ""}, {'1', "one hundred"}, {'2', "two hundred"}, {'3', "three hundred"}, {'4', "four hundred"}, {'5', "five hundred"}, {'6', "six hundred"}, {'7', "seven hundred"}, {'8', "eight hundred"}, {'9', "nine hundred"} };
         public Dictionary<char, string> thousandsDictionary = new Dictionary<char, string>() { {'0', ""}, {'1', "one thousand"}, {'2', "two thousand"}, {'3', "three thousand"}, {'4', "four thousand"}, {'5', "five thousand"}, {'6', "six thousand"}, {'7', "seven thousand"}, {'8', "eight thousand"}, {'9', "nine thousand"} };
         

        public Translate (string number)
        {
            Number = number;
            StringOutput = "";
        }

        public void ConvertNumber()
        {
            string zeroes = "";
            for (int i = 0; i < 4-Number.Length; i++)
            {
                zeroes += "0";
            }
            string numberToConvert = zeroes + Number;

            char[] numberArray = numberToConvert.ToCharArray();
            string[] wordsArray = new string[numberArray.Length];

            wordsArray[0] = thousandsDictionary[numberArray[0]];
            wordsArray[1] = hundredsDictionary[numberArray[1]];

            if (numberArray[2] == '1')
                if (numberArray[3] == '0')
                {
                    wordsArray[2] = "ten";
                }
                else if (numberArray[3] == '1')
                {
                    wordsArray[2] = "eleven";
                }
                else if (numberArray[3] == '2')
                {
                    wordsArray[2] = "twelve";
                }
                else if (numberArray[3] == '3')
                {
                    wordsArray[2] = "thirteen";
                }
                else if (numberArray[3] == '5')
                {
                    wordsArray[2] = "fifteen";
                }
                else if (numberArray[3] == '8')
                {
                    wordsArray[2] = "eighteen";
                }
                else
                {
                    wordsArray[0] = onesDictionary[numberArray[1]] + "teen";
                }
            else
            {
                wordsArray[2] = tensDictionary[numberArray[2]];
                wordsArray[3] = onesDictionary[numberArray[3]];
            }
            StringOutput = string.Join(" ", wordsArray);
            Console.WriteLine(StringOutput);
        }
    }
}
