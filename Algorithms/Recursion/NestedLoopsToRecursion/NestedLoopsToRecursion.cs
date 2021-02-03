using System;
using System.Collections.Generic;
using System.Linq;

namespace NestedLoopsToRecursion
{
    class NestedLoopsToRecursion
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            //PrintNestedLoops(input);
        }

        // This solution is not mine
        //private static void PrintNestedLoops(int loopCount)
        //{
        //    IterateNestedLoops(new Stack<int>(), 0, loopCount);
        //}

        //private static void IterateNestedLoops(Stack<int> nestedLoops, int currentIteration, int iterationCount)
        //{
        //    if (currentIteration == iterationCount)
        //    {
        //        Console.WriteLine(string.Join(" ", nestedLoops.Reverse()));
        //        return;
        //    }

        //    for (int currentNumber = 1; currentNumber <= iterationCount; currentNumber++)
        //    {
        //        nestedLoops.Push(currentNumber);
        //        IterateNestedLoops(nestedLoops, currentIteration + 1, iterationCount);
        //        nestedLoops.Pop();
        //    }
        //}
    }
}
