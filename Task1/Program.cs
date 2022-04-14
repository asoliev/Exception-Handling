using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter some text: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Empty string!");
                    Console.ResetColor();
                }
                else Console.WriteLine($"first character: '{input[0]}'");
                Console.WriteLine();
            }

        }
    }
}
//using (resource) { } // it is like try - finally
//finaly may not be called when 3 critical exceptions raised: stackoverflow, memory exceed, ...
//catch (Exception ex) when ex.Message == null //extra check of exception