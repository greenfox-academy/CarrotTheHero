﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenThirdTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            garden.Water(40);
            garden.Water(70);
            Console.ReadLine();
        }
    }
}
