using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        // member variables (HAS A)
        Player player1;
        Player player2;



        // constructor



        // member methods

        public void RunGame()
        {
            DisplayRules();
            string numberOfPlayers = ChooseNumberPlayers();
            CreatePlayers(numberOfPlayers);
            player1.ChooseName();
            player2.ChooseName();
            player1.ChooseGesture();
            player2.ChooseGesture();
            DetermineRoundWinner();
            

            while(player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();

                player2.ChooseGesture();

                DetermineRoundWinner();
                if (player1.score == 2)
                {
                    WinCondition();
                }
                else if(player2.score == 2)
                {
                    WinCondition();
                }
            }
        }

        
        public string ChooseNumberPlayers()
        {
            Console.WriteLine("How many players?");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }

        public void CreatePlayers(string NumberPlayers)
        {
            if(NumberPlayers == "1")
            {
                player1 = new HumanPlayer();
                player2 = new CPUPlayer();
            }
            else if(NumberPlayers == "2")
            {
                player1 = new HumanPlayer();
                player2 = new HumanPlayer();
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules.");
        }

        public void WinCondition()
        {
            Console.WriteLine("You Won!");
            Console.ReadLine();
        }

        public void DetermineRoundWinner()
        {
            if(player1.choice == player2.choice)
            {
                Console.WriteLine("Players tied this round.");
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);
            }
            else if((player1.choice == "Rock") && (player2.choice == "Scissors" || player2.choice == "Lizard"))
            {
                Console.WriteLine(player1.name + " Wins the round!");
                player1.score++;
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);

            }
            else if ((player1.choice == "Paper") && (player2.choice == "Rock" || player2.choice == "Spock"))
            {
                Console.WriteLine(player1.name + " Wins the round!");
                player1.score++;
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);
            }
            else if ((player1.choice == "Scissors") && (player2.choice == "Paper" || player2.choice == "Lizard"))
            {
                Console.WriteLine(player1.name + " Wins the round!");
                player1.score++;
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);
            }
            else if ((player1.choice == "Lizard") && (player2.choice == "Spock" || player2.choice == "Paper"))
            {
                Console.WriteLine(player1.name + " Wins the round!");
                player1.score++;
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);
            }
            else if ((player1.choice == "Spock") && (player2.choice == "Lizard" || player2.choice == "Scissors"))
            {
                Console.WriteLine(player1.name + " Wins the round!");
                player1.score++;
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);

            }
            else
            {
                Console.WriteLine(player2.name + " Wins the round!");
                player2.score++;
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);
            } 
            //Console.WriteLine(player1.name = "'s score is " + player1.score + " " + "Player 2's score " + player2.score);
        }
    }
}
        
