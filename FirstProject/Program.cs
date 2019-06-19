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
                    Console.WriteLine("Jim N' Nicks BBQ");
                
                }
                if (response == "no")
                    Console.WriteLine("Moe's BBQ");
            }
            if (response == "no")
                Console.WriteLine("Too Bad, because we have great BBQ");
            else if (response == "no")
            {
                
            }
        }   
    }
}
