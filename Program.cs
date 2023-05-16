using System;

namespace ScissorPaperRock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, cpuPlayer;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Choose between Scissor, Paper and Rock: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rand = new Random();

                    randomInt = rand.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            cpuPlayer = "ROCK";
                            Console.WriteLine("Computer choose rock");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW \n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player WINS\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            cpuPlayer = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 3:
                            cpuPlayer = "SCISSORS";
                            Console.WriteLine("Computer choose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS\n\n");
                                scoreCPU++;
                            }

                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            break;
                    }
                    Console.WriteLine("\n\n Scores are = Player:{0}, CPU:{1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER WINS");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WINS");
                }
                else { }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if(loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if(loop == "n")
                {
                    playAgain = false;
                }
                else { }

            }
        }
    }
}
