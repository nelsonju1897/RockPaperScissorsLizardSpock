using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            //display rules x
            //choose 1 player vs. computer or 2 player x
            //get player names
            //Choose a gesture
            //Determine round winner, then ++ the score for the winner
            //Check scores against condition of best two out of three to see if there is a winner
            //If yes: Display Congrats
            //If no: Repeat steps 4 through 7
            //Ask to play again
            //If yes: new game
            //If no: Exit application
            Game game = new Game();
            game.RunGame();




        }
    }
}
