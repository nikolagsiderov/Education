using System;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var result = GetReversedArray(input);

            Print(result);
        }

        private static string[] GetReversedArray(string[] input)
        {
            var reversedArr = new string[input.Length];
            reversedArr = FillInReversedArr(reversedArr, 0, input);

            return reversedArr;
        }

        private static string[] FillInReversedArr(string[] arr, int index, string[] input)
        {
            if (index == input.Length)
                return arr;

            arr[index] = input[input.Length - (index + 1)];
            arr = FillInReversedArr(arr, index + 1, input);

            return arr;
        }

        private static void Print(string[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
