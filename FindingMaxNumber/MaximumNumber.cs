﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaxNumber
{
    public class MaximumNumber
    {
        public int FindMaxFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is greater: " + first);
                return (int)first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is greater: " + second);
                return (int)second;
            }
            else
            {
                Console.WriteLine("Third Number is greater: " + third);
                return (int)third;
            }
        }
    }
}
