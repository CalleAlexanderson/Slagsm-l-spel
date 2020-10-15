
using System;

namespace Slagsmål_spel
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Namnge din kämpe");
            string name = Console.ReadLine();
            int game = 1;
            int turn = 0;
            int playerhp = 100;
            int opponenthp = 100;
            Console.Clear();
            while (game == 1)
            {
                if (playerhp == 0 || opponenthp == 0)
                {
                    if (opponenthp == 0 && playerhp > 0)
                    {
                        Console.WriteLine("You win");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }
                    Console.ReadLine();
                    game = 0;
                }
                else
                {
                    turn++;
                    playerhp = Fight1(playerhp);
                    opponenthp = Fight2(opponenthp);
                    if (playerhp < 0)
                    {
                        playerhp = 0;
                    }
                    if (opponenthp < 0)
                    {
                        opponenthp = 0;
                    }
                    Console.WriteLine("turn " + turn + "\n" + name + " has " + playerhp + " hitpoints left" + "\n" + "opponent has " + opponenthp + " hitpoints left");
                    Console.ReadLine();

                }
            }
        }

        static int Fight1(int currentPHP)
        {

            Random generator = new Random();
            int opdamage = generator.Next(1, 31);
            currentPHP = currentPHP - opdamage;

            return currentPHP;
        }

        static int Fight2(int currentOPHP)
        {
            Random generator = new Random();
            int pdamage = generator.Next(1, 31);
            currentOPHP = currentOPHP - pdamage;

            return currentOPHP;
        }
    }


}
