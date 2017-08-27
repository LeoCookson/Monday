using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
			
            Console.WriteLine("This program will display the number you type in");
            var number = 0;

            Console.WriteLine("Please enter a number");
            var isNumber = int.TryParse(Console.ReadLine(), out number);

            if(isNumber){
                Console.WriteLine($"The number is {number}");
            }
            else{
                Console.WriteLine("You did not type in a number");
            }

			
            
            
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
