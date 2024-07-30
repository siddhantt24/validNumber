using System;
using System.IO;

namespace FileCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Sid-folder\siddhant.txt"; 

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("Existing file deleted.");
                }

                File.Create(filePath).Close();
                Console.WriteLine("New file created successfully.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error creating file: " + e.Message);
            }
        }
    }
}
