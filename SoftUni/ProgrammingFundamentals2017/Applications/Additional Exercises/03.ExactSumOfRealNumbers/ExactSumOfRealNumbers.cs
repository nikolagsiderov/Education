﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal numToSum = decimal.Parse(Console.ReadLine());
                sum += numToSum;
            }

            Console.WriteLine(sum);
        }
    }
}
