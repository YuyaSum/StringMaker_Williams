using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Williams
{
    class StringManager
    {
        public string OGWord { get; set; }
        public string ModWord { get; set; }

        public string Reverse(string s) {
            string reverse = "";

            for (int i = s.Length-1; i > -1; i-- ) {
                reverse += s[i];
            }

            ModWord = reverse;

            return ModWord;
        }
        public string Reverse(string s, bool preserve) {
            string isLower = "";
            string lowerReverse = "";
            string reverse = "";
            List<int> capLocation = new List<int>();

            for (int i = 0; i < s.Length; i++) {
                if (char.IsUpper(s[i]))
                {
                    capLocation.Add(i);
                    isLower += char.ToLower(s[i]);
                }
                else 
                { 
                    isLower += s[i];
                }
            }

            for (int i = isLower.Length - 1; i > -1; i--)
            {
                lowerReverse += isLower[i];
            }

            for (int i = 0; i < lowerReverse.Length; i++) {
                for (int j = 0; j < capLocation.Count(); j++) {
                    if (i == capLocation[j]) {
                        reverse += char.ToUpper(lowerReverse[i]);
                    }
                }
                if (i != reverse.Length - 1) {
                    reverse += lowerReverse[i];
                }
            }

            ModWord = reverse;

            return ModWord;
        }
        public bool Symmetric(string s) {

            bool sameLetter = false;
            int end = s.Length - 1;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != s[end]) {
                    sameLetter = false;
                    break;
                }
                end--;
                sameLetter = true;


                //for (int j = s.Length - 1; j >s.Length-i; j--)
                //{
                //    if (s[i] != s[j]) {
                //        return false;
                //    }
                //    if (i == Math.Floor(s.Length / 2.0) && j == Math.Ceiling(s.Length / 2.0))
                //    {
                //        return true;
                //    }
                //    else if (i == j) {
                //        return true;
                //    }
                //}
            }

            return sameLetter;
        }
        //Override ToString to return a string representation of the string input summed ASCII values
        public override string ToString() {
            string[] numWords = new string[] {"Zero", "One", "Two", "Three", "Four", "Five", 
                "Six", "Seven", "Eight", "Nine"};
            string word = this.OGWord;
            int ASCII = 0;
            string ASCIIWord = "";

            foreach (char c in word)
            {
                ASCII += (int)c;
            }

            word = ASCII.ToString();

            foreach (char c in word)
            {
                for (int i = 0; i < numWords.Length; i++) {
                    if (c.ToString() == i.ToString()) {
                        ASCIIWord += numWords[i] + " ";
                    }
                }
            }

            ModWord = ASCIIWord;
            
            return ModWord;
        }
        
        //Override Equals() to compare the current data input to the class with a literal or variable string
        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                if ((string)obj == OGWord)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }
    }
}
