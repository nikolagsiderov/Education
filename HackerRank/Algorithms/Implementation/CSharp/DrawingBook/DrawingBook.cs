using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class DrawingBook
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pageGoal = int.Parse(Console.ReadLine());

            int minFromStart = GetPagesFromStart(pages, pageGoal);
            int minFromEnd = GetPagesFromEnd(pages, pageGoal);

            if ((pages % 2 != 0 && pages - 1 == pageGoal) || pages == pageGoal)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (minFromStart <= minFromEnd)
                {
                    Console.WriteLine(minFromStart);
                }
                else
                {
                    Console.WriteLine(minFromEnd);
                }
            }
        }

        static int GetPagesFromStart(int pages, int pageGoal)
        {
            int pagesTurned = 0;

            for (int i = 1; i <= pages; i += 2)
            {
                if (pageGoal <= i)
                {
                    break;
                }

                pagesTurned++;
            }

            return pagesTurned;
        }

        static int GetPagesFromEnd(int pages, int pageGoal)
        {
            int pagesTurned = 0;

            for (int i = pages; i >= 1; i -= 2)
            {
                if (i == pageGoal)
                {
                    break;
                }
                else
                {
                    if (pages % 2 != 0)
                    {
                        if (i - 1 == pageGoal)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (i + 1 == pageGoal)
                        {
                            break;
                        }
                    }
                }

                pagesTurned++;
            }

            return pagesTurned;
        }
    }
}
