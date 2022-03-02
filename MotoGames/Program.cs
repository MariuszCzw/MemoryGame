using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MotoGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            string path = @"C:\Users\Mariusz\source\repos\Program\Program\Words.txt";
            if (!File.Exists(path))
            {
                sw=File.CreateText(path);
                Console.WriteLine("Plik zostal utworzony");
            }
            
        }
    }
}
