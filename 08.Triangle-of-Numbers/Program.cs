using System;

namespace _08.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
