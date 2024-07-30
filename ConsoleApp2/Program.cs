using System;
using System.IO;

namespace FileDeletion
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
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error deleting file: " + e.Message);
            }
        }
    }
}
