using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfRockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _PlayerScore = 0, _ComputerScore = 0;
            string _ExitKey = "";

            while (_ExitKey != "e") //Kullanıcı exit in e sine basmadığı sürece oyunun devam etmesini isticem.
            {
                Console.Clear();
                Console.WriteLine("Rock-Paper-Scissors");
                Console.WriteLine("Choose [r]ock,[p]aper, [s]cissors or [e]xit");
                string _PlayerMove = "";
            GetInput:
                switch (Console.ReadLine().ToLower())
                {
                    case "r":
                        _PlayerMove = "rock";
                        break;

                    case "p":
                        _PlayerMove = "paper";
                        break;

                    case "s":
                        _PlayerMove = "scissors";
                        break;

                    case "e":
                        _ExitKey = "e";
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input...Please try again.");
                        goto GetInput;
                        break;
                }
                Console.WriteLine($"Your choose {_PlayerMove} ");
                Random rnd = new Random();
                int random = rnd.Next(3); // 0,1,2
                string _ComputerMove = "";
                switch (random)
                {
                    case 0:
                        _ComputerMove = "rock";
                        break;
                    case 1:
                        _ComputerMove = "paper";
                        break;
                    case 2:
                        _ComputerMove = "scissors";
                        break;


                    default:
                        break;
                }
                Console.WriteLine($"Computer's move {_ComputerMove}");
                if ((_PlayerMove == "rock" && _ComputerMove == "paper") || (_PlayerMove == "scissors" && _ComputerMove == "rock") ||
                        (_PlayerMove == "paper" && _ComputerMove == "scissors"))
                {
                    _ComputerScore++;
                    Console.WriteLine("You lost.Computer won.");
                }
                else if ((_ComputerMove == "rock" && _PlayerMove == "paper") || (_ComputerMove == "scissors" && _PlayerMove == "rock") ||
                        (_ComputerMove == "paper" && _PlayerMove == "scissors"))
                {
                    _PlayerScore++;
                    Console.WriteLine("You won.Computer lost.");

                }
                else
                {
                    Console.WriteLine("Draw / Game is tie");
                }
                Console.WriteLine($"Your score {_PlayerScore} and Computer's score {_ComputerScore} ");
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();








            }
        }
    }
}
