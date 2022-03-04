using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class ElectronicsShop
    {
        static void Main(string[] args)
        {
            List<int> firstLineInputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> keyboardPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> USBPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int budget = firstLineInputParams[0];
            int max = -1;

            for (int i = 0; i < keyboardPrices.Count; i++)
            {
                int currentKeyboardPrice = keyboardPrices[i];

                for (int j = 0; j < USBPrices.Count; j++)
                {
                    int currentUSBPrice = USBPrices[j];

                    if (currentKeyboardPrice + currentUSBPrice >= max)
                    {
                        if (budget >= currentKeyboardPrice + currentUSBPrice)
                        {
                            max = currentKeyboardPrice + currentUSBPrice;
                        }
                    }
                }
            }

            if (max >= 0)
            {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
