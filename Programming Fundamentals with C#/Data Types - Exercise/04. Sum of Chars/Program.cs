﻿using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                totalSum += letter;
             
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
