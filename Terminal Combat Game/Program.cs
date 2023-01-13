using System;

namespace Turnbasedcombat
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;
            int playerAttack = 5;
            int enemyAttack = 7;
            int healAmount = 5;

            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                // Player turn
                Console.WriteLine("-- Player turn --");
                Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
                Console.WriteLine("Enter 'A' to attack or 'H' to heal.");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attacks and deals " + playerAttack + " damage!");
                }
                else
                {
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                    playerHp += healAmount;
                }

                // Enemy turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy turn --");
                    Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
            }

            if (playerHp > 0)
            {
                Console.WriteLine("Congratulations, you have won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}