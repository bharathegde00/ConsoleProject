using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    public class ques1
    {
        public static void Main()
        {
            int a, b, c;

            Console.Write("Input the first number to multiply: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            c = int.Parse(Console.ReadLine());

            int result = a * b * c;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}", a, b, c, result);

        }
    }
    
    
}
