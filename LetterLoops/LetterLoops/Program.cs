using System;

namespace LetterLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your input");
            var myString = Console.ReadLine().ToLower();
            foreach (var input in myString)
            {
                for (var i = 0; i <= myString.IndexOf(input); i++)
                {
                    if (i == 0)
                    {
                        Console.Write(input.ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(input);
                    }
                }
                if (myString.IndexOf(input) != myString.Length - 1)
                {
                    Console.Write("-");
                }
            }
            Console.ReadLine();
        }
    }
}
