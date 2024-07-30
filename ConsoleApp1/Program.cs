using System;
using System.IO;

namespace LineCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "F:\\Sid-folder\\sid.txt"; 

            try
            {
                int lineCount = 0;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                        lineCount++;
                    }
                }

                Console.WriteLine("Number of lines in the file: " + lineCount);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file: " + e.Message);
            }
        }
    }
}
