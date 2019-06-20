using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Birmingham");
            Console.WriteLine("We have great places to eat");
            Console.WriteLine("Are you hungry?");
            string response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Great, let me recommend BBQ.");
                Console.WriteLine("Do you want table service?");
                response = Console.ReadLine();
                if (response == "yes")
                {
                    Console.WriteLine("Jim N' Nicks BBQ is my suggestion");
                    Console.WriteLine("Are you ready to order?");
                    response = Console.ReadLine();
                    if (response == "yes")
                    {
                        Console.WriteLine("Meal 1, 2, or 3?");
                        response = Console.ReadLine();
                        if (response == "1")
                            Console.WriteLine("You're getting a pulled pork sandwich.");
                        else if (response == "2")
                            Console.WriteLine("You're getting the brisket plate.");
                        else if (response == "3")
                            Console.WriteLine("You're getting a rib plate.");
                        else
                            Console.WriteLine("Well you're not going to eat then.");
                    }

                }
                else if (response == "no")
                    Console.WriteLine("Moe's BBQ");
            }
            else if (response == "no")
                Console.WriteLine("Too Bad, because we have great BBQ");
            else
                Console.WriteLine("You're wasting my time!");
        }   
    }
}
