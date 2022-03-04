﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.AppendLists
{
    public class AppendLists
    {
        public static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();

            List<string> result = new List<string>();

            foreach (var item in items)
            {
                List<string> nums = item.Split(' ').ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}