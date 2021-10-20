using System;

namespace FileIOoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is File Operation Demo");
            FileOperations.FileExists();
            FileOperations.ReadAllLines();
            FileOperations.ReadAllText();
            //FileOperations.Copy();
            FileOperations.Delete();
            Console.ReadLine();
        }
    }
}
