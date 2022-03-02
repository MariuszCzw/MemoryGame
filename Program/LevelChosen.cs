using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class LevelChosen
    {
        public static void LevelChosen2()
        {
            Console.WriteLine("Hi. Unfortunately, I did not manage to complete the task, but I am sending what I have. I intend to continue working on expanding my knowledge and skills and I will check whether there are new editions of the Academy, so I would not like to be perceived as a lazy person, but as a person who is still lacking skills.Have a nice day.");

            Console.WriteLine("Chose level:");
            Console.WriteLine("Poziom 1: 4 randomly selected words, 10 changes to reveal all memory");
            Console.WriteLine("Poziom 2: 8 randomly selected words, 15 changes to reveal all memory");
            int levelChosen;
            bool isTrue = int.TryParse(Console.ReadLine(), out levelChosen);
            if (levelChosen == 1) 
            { 
                Console.WriteLine("Wybrałeś poziom łatwy");
                DrawFunction.DrawFuncions(levelChosen);
            }
            else if (levelChosen == 2) 
            { 
                Console.WriteLine("Wybrałeś poziom trudny");
                DrawFunction.DrawFuncions(levelChosen);

            }
            else
            {
                Console.WriteLine("Wrong chose: please chose between level 1 and 2");
                Console.WriteLine("");
                Console.WriteLine("******************************************");
                LevelChosen.LevelChosen2();
            }
        }

    }
}