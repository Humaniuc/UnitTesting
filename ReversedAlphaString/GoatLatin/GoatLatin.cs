using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    public class GoatLatin
    {
        enum vowels { a, e, i, o, u };
        public string GoatLatinSentence(string str)
        {
            string[] words = str.Split((char)32);

            StringBuilder strBuild = new StringBuilder();
            int index = 0;

            foreach(string word in words)
            {
                index++;
                if (Enum.GetNames(typeof(vowels)).Contains(word.Substring(0, 1)))
                {
                    strBuild.Append(word + "ma" + string.Empty.PadRight(index, 'a') + " ");
                }
                else
                {
                    strBuild.Append(word.Substring(1, word.Length - 1) + word[0] + "ma" + string.Empty.PadRight(index, 'a') + " ");
                }
            }

            string s = strBuild.ToString().TrimEnd();

            return s;
        }
    }
}
