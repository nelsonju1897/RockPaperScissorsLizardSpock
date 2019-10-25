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
            

            while(player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();

                player2.ChooseGesture();

                DetermineRoundWinner();
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

        }

        public void DetermineRoundWinner(string player1Choice, string player2Choice)
        {
            if(player1Choice == "Rock" && player2Choice == "Scissors" || player2Choice == "Lizard")
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }
            else if (player1Choice == "Paper" && player2Choice == "Rock" || player2Choice == "Spcok")
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }
            else if (player1Choice == "Scissors" && player2Choice == "Paper" || player2Choice == "Lizard")
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }
            else if (player1Choice == "Lizard" && player2Choice == "Spock" || player2Choice == "Paper")
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }
            else if (player1Choice == "Spock" && player2Choice == "Lizard" || player2Choice == "Scissors")
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }
            else
            {
                Console.WriteLine(player2.name + " Wins!");
            }
        }
    }
}
        
