﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public string HasSunRoof { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("going somewhere");
        }
    }
}