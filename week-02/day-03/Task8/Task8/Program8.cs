﻿using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.

            foreach (string words in far)
            {
                Console.WriteLine(words+"a");
            }
            Console.ReadLine();
        }
    }
}