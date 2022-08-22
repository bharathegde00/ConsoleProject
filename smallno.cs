using System;
public class ques2
{
    static void Main(string[] args)
    {
        Console.Write("Input first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            Console.WriteLine($"The smaller number is {a}");
        }

        else if (a > b)
        {
            Console.WriteLine($"The smaller number is {b}");
        }

        else
        {
            Console.WriteLine("The numbers are equal");
        }
    }
}