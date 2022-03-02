using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryGame

{
    public class ReadFile

    {

        public static string[] ReadFiles()
        {
            var textFile = File.ReadAllLines(@"C:\Users\Mariusz\source\repos\Program\Program\Words.txt");
            var document2String = string.Join(Environment.NewLine, textFile);
            string[] newDocument = document2String.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int tabLength = newDocument.Length;
            return newDocument;
        }
        public static int TabLength()
        {
            var tabLengthHelp = ReadFiles();
            return tabLengthHelp.Length;
        }
    }
}
