using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class DrawFunction
    {
        public static void DrawFuncions(int length)
        {
            Random rand = new Random();
            int tabLength = ReadFile.TabLength();
            //Console.WriteLine(length);
            if (length == 1)
            {
                int[] numbers = new int[tabLength];
                int[] numberStorage = new int[4];
                for (int i = 0; i < tabLength; i++)
                {
                    numbers[i] = i + 1;
                }
                    
                for (int i = 0; i < 4; i++)
                {
                    int r = rand.Next(tabLength);
                    numberStorage[i] = r;
                    //Console.WriteLine(numbers[r]);
                    numbers[r] = numbers[tabLength - 1];
                    tabLength--;                   
                }
                GameClass.Game(numberStorage);
            }
            else
            {
                int[] numbers = new int[tabLength];
                int[] numberStorage = new int[8];
                for (int i = 0; i < tabLength; i++)
                {
                    numbers[i] = i + 1;
                }

                for (int i = 0; i < 8; i++)
                {
                    int r = rand.Next(tabLength);
                    numberStorage[i] = r;
                    //Console.WriteLine(numbers[r]);
                    numbers[r] = numbers[tabLength - 1];
                    tabLength--;
                }
                GameClass.Game(numberStorage);
            }
        }
    }
}
