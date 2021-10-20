using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOoperations
{
    class FileOperations
    {

        public static void FileExists()
        {
            String path = @"C:\Users\MounikaA\Desktop\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("FileExists");

            }
            else
            {
                Console.WriteLine("Not Exists");
            }

            Console.ReadKey();

        }
        public static void ReadAllLines()
        {

            String path = @"C:\Users\MounikaA\Desktop\Example.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadKey();

        }
        public static void ReadAllText()
        {
            String path = @"C:\Users\MounikaA\Desktop\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            
        }
        public static void Copy()
        {
            String path = @"C:\Users\MounikaA\Desktop\Example.txt";
            String copypath = @"C:\Users\MounikaA\Desktop\ExampleNew.txt";
            File.Copy(path, copypath);
            Console.ReadKey();
        }
        public static void Delete()
        {
            String path = @"C:\Users\MounikaA\Desktop\Examplecopy.txt";
            File.Delete(path);
            Console.WriteLine();
        }
    }
}
