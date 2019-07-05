using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedAlphaString
{
    public class StringUtils
    {
        public string ReverseUsingStringBuilder(string s)
        {
            if (!String.IsNullOrEmpty(s))
            {
                StringBuilder strRev = new StringBuilder();
                int right = s.Length - 1;
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsLetter(s[i]))
                    {
                        while (!Char.IsLetter(s[right]))
                        {
                            right--;
                        }
                        strRev.Append(s[right]);
                        right--;
                    }
                    else
                    {
                        strRev.Append(s[i]);
                    }
                }
                return strRev.ToString();
            }
            else
            {
                throw new ArgumentNullException("Null or empty");
            }
        }
    }
}
