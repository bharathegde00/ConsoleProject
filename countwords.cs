using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ques4
    {
        public static void Main()
        {
            int a = 0, myWord = 1;
            string str = "Number of words in this string";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    myWord++;
                }
                a++;
            }
            Console.Write("Number of words in the string = {0}\n", myWord);
        }
    }
}