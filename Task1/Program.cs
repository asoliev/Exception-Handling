using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter some text: ");
                    string input = Console.ReadLine();
                    Console.WriteLine($"first character: '{input[0]}'");
                }
                catch (IndexOutOfRangeException ex)
                {
                    string msg = ex.Message;
                    //Console.WriteLine(ex.Message);
                    var defaultForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Empty string!");
                    Console.ForegroundColor = defaultForegroundColor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}