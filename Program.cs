using System;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the RPS Thunder Dome");
            Console.WriteLine("Are you in? yes/no");
            Console.Write(">");
            String ans = Console.ReadLine();
            int player = 0;
            int comp = 0;

            while (ans != "no")
            {
                Console.WriteLine("Choose your weapon");
                Console.WriteLine("rock, paper, or scissors....");
                Console.Write(">");
                string[] choices = new string[3]
                {
                    "rock",
                    "paper",
                    "scissors"
                };
                Random rnd = new Random();
                int c = rnd.Next(0,3);
                string user = Console.ReadLine();
                Console.WriteLine("you chose:" + user);
                Console.WriteLine("computer chose:" + choices[c]);

                if (user == "rock" && choices[c] == "scissors")
                {
                    Console.WriteLine("You have won this round...");
                    player ++;
                }
                else if (user == "paper" && choices[c] == "rock")
                {
                    Console.WriteLine("You have won this round...");
                    player ++;
                }
                else if (user == "scissors" && choices[c] == "paper")
                {
                    Console.WriteLine("You have won this round...");
                    player ++;
                }
                else if (user == "paper" && choices[c] == "scissors")
                {
                    Console.WriteLine("You have been Defeated");
                    comp ++;
                }
                else if (user == "rock" && choices[c] == "paper")
                {
                    Console.WriteLine("You have been defeated!");
                    comp ++;
                }
                else if (user == "scissors" && choices[c] == "rock")
                {
                    Console.WriteLine("You have been Defeated");
                    comp ++;
                }
                else
                {
                    Console.WriteLine("DRAW");
                }
                Console.WriteLine("You have aquired " + player + " W's");
                Console.WriteLine("You have been handed " + comp + " L's");
                Console.WriteLine("Dare to play again?? yes/no");
                ans = Console.ReadLine();
            }
        }
    }
}
