using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            // Implement this.
            string filePath = @"C:\Users\alex\Desktop\WordUnscrambler\scrambledWords.txt";

            //string[] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            Console.ReadLine();
            foreach (String line in lines)
            {

                Console.WriteLine(line);
            }

            return null;

        }
    }
}