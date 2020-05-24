using System;

namespace _04.Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1from = int.Parse(Console.ReadLine());
            int num2to = int.Parse(Console.ReadLine());
            int sumNum = 0;

            for (int i = num1from; i <= num2to ; i++)
            {
                int currentNum = i;
                Console.Write($"{currentNum} ");
                sumNum += currentNum;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumNum}");
        }
    }
}
