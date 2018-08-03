using System;

namespace CG_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This initial part of the code gets the user to input the number that we will
            be using to multiply within the loop.

            Console.WriteLine("Please enter a number");
            var multi = Console.ReadLine();
            var multiplier = int.Parse(multi);

            /*This is the part of the code that makes the loop.  It is saying that it starts at 2
             and continues until 20.
             Unrelated side note -- I NEVER KNOW WHAT TO NAME VARIABLES.*/

           
            for (int number = 2; number < 21; number++)
            {
                Console.WriteLine("Please enter a number");
                var multi = Console.ReadLine();
                var multiplier = int.Parse(multi);

                var numbs = multiplier * number;

                Console.WriteLine(numbs);

            }


            Console.ReadLine();

        }
    }
}
