using System;

namespace QuestionNo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            // Input a string, store it in a variable and then convert that string variable into an integer
            var NumberString = Console.ReadLine();
            int Number = Convert.ToInt32(NumberString);

            // if statement to determine even or odd

            if (Number % 2 == 0)
            {
                Console.WriteLine("The number is even!");
            }
            else
            {
                Console.WriteLine("The number is odd!");
            }
            


            
            
        }
    }
}
