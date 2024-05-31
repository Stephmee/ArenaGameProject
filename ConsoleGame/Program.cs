using ArenaGame;
using System;
using System.Collections.Generic;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Console.Write("Enter number of battles: ");
            int rounds = Int32.Parse(Console.ReadLine());

            int oneWins = 0, twoWins = 0, threeWins = 0, fourWins = 0;


            for (int i = 0; i < rounds; i++)
            {

                Console.WriteLine($"Battle {i + 1}:");

                Hero one = ChooseHero("Enter first hero: ");
                Hero two = ChooseHero("Enter second hero:");


                do
                {
                    if (one.Name == two.Name)
                    {
                        Console.WriteLine("Second hero is the same as the first one");
                        Hero twoNew = ChooseHero("Enter second hero:");
                        two = twoNew;
                    }

                }
                while (one.Name == two.Name);

                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");

                if (winner.Name == "Sir Lancelot")
                {
                    oneWins++;
                }
                else if (winner.Name == "Robin Hood")
                {
                    twoWins++;
                }
                else if (winner.Name == "Maleficent")
                {
                    threeWins++;
                }
                else if (winner.Name == "Ghandi")
                {
                    fourWins++;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Knight has {oneWins} wins.");
            Console.WriteLine($"Rogue has {twoWins} wins.");
            Console.WriteLine($"Witch has {threeWins} wins.");
            Console.WriteLine($"Monk has {fourWins} wins.");


            Console.ReadLine();

        }

        static Hero ChooseHero(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("1.Knight");
            Console.WriteLine("2.Rogue");
            Console.WriteLine("3.Witch");
            Console.WriteLine("4.Monk");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    return new Knight();
                case 2:
                    return new Rogue();
                case 3:
                    return new Witch();
                case 4:
                    return new Monk();
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    return ChooseHero(message);

            }
        }
    }
}
