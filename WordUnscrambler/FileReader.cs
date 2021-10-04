using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            //declare a string[] to hold the contents of the file
            string[] readFiles;

            //try/catch
            try
            {
                //read from the file - ReadAllLines()
                readFiles = File.ReadAllLines(filename);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return readFiles;

            //Return file contents, which is a string[]


        }
    }
}