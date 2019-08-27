using System;

namespace NumberMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some numbers, and separate them with commas. No spaces!");

            string input = Console.ReadLine();
            string[] inputArray = input.Split(',');
            int total = 1;
            string squareOutput = "";

            Console.WriteLine("To multiply the numbers, press 1. To square the numbers, press 2.");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                foreach (string val in inputArray)
                {
                    int number = int.Parse(val);
                    total *= number;
                }
                Console.WriteLine(total);
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                foreach (string val in inputArray)
                {
                    int number = int.Parse(val);
                    string numString = Convert.ToString(number * number);
                    squareOutput += numString;
                    squareOutput += ',';
                }
                string finalOutput = squareOutput.Remove(squareOutput.Length - 1);
                Console.WriteLine(finalOutput);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I told you to pick 1, or 2. Goodbye.");
                Console.ReadKey();
            }
        }
    }
}