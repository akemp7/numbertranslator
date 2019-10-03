using System.Collections.Generic;
using System;

namespace NumberTranslate.Models
{
    public class Translate
    {
        public int Number { get; set; }
        public string StringOutput { get; set; }

        public Dictionary<int, string> onesDictionary = new Dictionary<int, string>() { {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"} };

        public Translate (int number)
        {
            Number = number;
            StringOutput = "";
        }

        public void ConvertNumber()
        {
            StringOutput = onesDictionary[Number];
        }
    }
}