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
             and continues until 20.
             Unrelated side note -- I NEVER KNOW WHAT TO NAME VARIABLES.*/



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
                 with nothing.  So I just figured I'd try again.  Now it wants to play nicely and do what I want.
                 I hate technology.*/


                    var numbs = multiplier * number;
               
                    Console.WriteLine(numbs);
                

                                
            }

                    
                 Console.ReadLine();

        }
    }
}
