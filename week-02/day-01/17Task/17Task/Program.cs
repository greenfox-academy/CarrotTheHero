﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            int num4 = Int32.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4;
            Console.WriteLine("Sum is: " + sum);

            double ave = (num1 + num2 + num3 + num4) / 4.0;
            Console.WriteLine("Average is: " + ave);

            Console.ReadLine();
        }
    }
}