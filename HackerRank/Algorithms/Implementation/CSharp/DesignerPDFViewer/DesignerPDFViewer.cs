using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPDFViewer
{
    class DesignerPDFViewer
    {
        static void Main(string[] args)
        {
            List<int> letterValue = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string word = Console.ReadLine();

            int maxValueLetter = GetMaxValueLetter(word, letterValue);

            Console.WriteLine(maxValueLetter*1*word.Length);
        }

        static int GetMaxValueLetter(string word, List<int> letterValue)
        {
            List<int> wordValue = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                int currentChar = word[i];

                wordValue.Add(letterValue[currentChar - 97]);
            }

            return wordValue.Max();
        }
    }
}
