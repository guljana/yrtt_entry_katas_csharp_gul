using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            /* String[] strlist = str.Split(' ');
             string output = "";
             foreach (String s in strlist)
             {
                 if (!Char.IsPunctuation(s, 0))
                 {
                     output += s.Substring(1) + s[0] + "ay ";

                 }
                 else
                 {
                     output += s;
                 }

             }
             return output.ToString().TrimEnd(' ');*/

            string[] strlist = str.Split(' ');
            List<string> res = new List<string>();
            foreach (string s in strlist)
            {
                string rep = Regex.Replace(s, @"(\w)(\w+)\s*([!.,;:]*)", "$2" + "$1" + "ay" + "$3");
                res.Add(rep);
            }
            return string.Join(" ", res);

            throw new NotImplementedException();
        }
    }
}

