﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmpWage
{
    internal class PorA
    {
        public void Wage()
        {
            int fullTime = 1;
            Random rnd = new Random();
            int attendCheck = rnd.Next(0, 2);
            if (attendCheck == fullTime)
            {
                Console.WriteLine("The Employee is present");
            }
            else
            {
                Console.WriteLine("The Employee is absent");
            }
        }
}
    }
