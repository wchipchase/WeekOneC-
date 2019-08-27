using System;

namespace NotHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime is the type of the purchaseData variable.
            DateTime purchaseDate = DateTime.Now;
            /*
               string is the type of the lastName variable
               It tells the compiler that the lastName variable
               can ONLY hold a string value.
            */
            string lastName = "Smith";
            /*
               C# now supports implicitly typing of a variable. 
               The type of the variable will be determined by the compiler at compile time.
            */
            var firstName = "Bill";

            Console.WriteLine($"{firstName} {lastName} visited on {purchaseDate}");
            Console.ReadLine(); // <-- Stops the program waiting for user input.

            // Not only do you have to say what type the variable is, you also have to 
            // instantiate that exact same type of object on assignment. This may seem 
            // redundant, but it's part of the C# language compiler's type checking constraints.
            string[] products = new string[] { "Motorcycle", "Sofa", "Sandals", "Omega Watch", "iPhone" };

            // This syntax should look very similar to what you did with Array.foreach in JS.  
            //  However, once again you have to explicitly say what type of variable product is. 
            //  Since the products array holds strings, then its type must be string.
            foreach (string product in products)
            {
                Console.WriteLine(product);

            }

            foreach (string product in products)
            {
                if (product.Length > 5)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
