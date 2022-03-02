using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryGame
{
    class GameClass
    {
        public static void Game(int[] numbers)
        {
            int[] k = new int[numbers.Length];
            Array.Copy(numbers, k, numbers.Length);

            int[]j = new int[numbers.Length];

            var MainWords = ReadFile.ReadFiles();

            string[,] words = new string[3,5];

            Console.Clear();

            words[0, 0] = "X";
            words[1, 0] = "A";
            words[2, 0] = "B";
            words[0, 1] = "1";
            words[0, 2] = "2";
            words[0, 3] = "3";
            words[0, 4] = "4";

            for(int i = 1; i < 5; i++) { words[1, i] = MainWords[i]; } //.length to create
            for(int m = 1; m < 5; m++) { words[2, m] = MainWords[m]; } //mix to create
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.Write(words[0,i] + "     ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(words[1, i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(words[2, i] + " ");
            //}
            Console.WriteLine();
            Console.WriteLine("Podaj proszę pozycję z wiersza A oraz wiersza B do odsłonięcia");


            string[,] tabWithX = new string[3, 5] { {"X","1","2","3","4"}, {"A","X","X","X","X"},
                                        {"B","X","X","X","X"} };

            for (int i = 0; i < 5; i++)
            {
                Console.Write(tabWithX[0, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(tabWithX[1, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(tabWithX[2, i] + " ");
            }

            int key1, key2;
            bool isTrue1=int.TryParse(Console.ReadLine(), out key1);
            bool isTrue2 = int.TryParse(Console.ReadLine(), out key2);
            if (words[1,key1]==words[2,key2])
            {
                Console.WriteLine("Success");
                //To create
                //GameClass.Switch(){ switch X to World; }
            }
            else { Console.WriteLine("Ups"); }
        }
    }
}
