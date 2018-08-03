using System;

namespace CG_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This initial part of the code gets the user to input the number that we will
            be using to multiply within the loop.*/

            Console.WriteLine("Please enter a number");
            var multi = Console.ReadLine();
            var multiplier = int.Parse(multi);

            /*This is the part of the code that makes the loop.  It is saying that it starts at 2
             and continues until 20. I introduced the "sum" variable now so that way I can use it
             after I get the loop values calculated.
             Unrelated side note -- I NEVER KNOW WHAT TO NAME VARIABLES.*/


            int sum = 0;
            for (int number = 2; number < 21; number++)
            {
                //Console.WriteLine("Please enter a number");
                //    var multi = Console.ReadLine();
                //    var multiplier = int.Parse(multi);
                /*So ^^ all of that.  See, at first I tried it like it is now but it didn't work
                 which I don't understand why it didn't work as it works now and I did not change
                 one freaking thing AT ALL so I tried putting it within the code.  Which *technically*
                 worked but you had to reenter the number every. single. time. And it was annoying.  So
                 I fiddled with it for at least a half hour, googling to figure out what I was doing wrong
                 with nothing.  I was questioning my understanding of this and the meaning of life.  It was
                 getting sketchy there for a minute. When all hope was lost and no answers found to solve my
                 conundrum, I just figured I'd try again.  Now it wants to play nicely and do what I want.
                 I left it in there so if I ever come back to it, I can remember "oh yeah, that doesn't work."
                 Also, I hate technology.*/


                    var numbs = multiplier * number;

                Console.WriteLine(numbs);

                /*This bit of code then takes all the values that were totalled out from the loop and adds
                them together to get the sum of them*/

                sum = sum + numbs;
                                
            }

            Console.WriteLine($"The sum of all previous values is {sum}.");
                 Console.ReadLine();

        }
    }
}
