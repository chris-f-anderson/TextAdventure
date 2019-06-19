using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Birmingham");
            Console.WriteLine("We've got a lot to offer");
            Console.WriteLine("We have good food, entertainment, and shopping");
            Console.WriteLine("Are you hungry?");
            string response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Let me recommend BBQ.");
                Console.WriteLine("Do you want table service?");
                response = Console.ReadLine();
                if (response == "yes")
                {
                    Console.WriteLine("Jim N' Nicks BBQ");

                }

            }
            else
            {
                Console.WriteLine("Moe's BBQ");
            }
        }   
    }
}
