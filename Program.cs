using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        Console.Write("Enter the source file path: ");
        string sourcePath = Console.ReadLine();

        if (!File.Exists(sourcePath))
        {
        Console.WriteLine("File not found! Make sure the path is correct.");
        return;
        }

        Console.Write("Enter the path to the destination file: ");
        string destinationPath = Console.ReadLine();

        File.Copy(sourcePath, destinationPath, true);
        Console.WriteLine("File copied successfully!");
    }
}