﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            Console.Write("Write down your name: ");
            string userName= Console.ReadLine();
            Console.WriteLine("Hello, " + userName);
            Console.ReadLine();


        }
    }
}