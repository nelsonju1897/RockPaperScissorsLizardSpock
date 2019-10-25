using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        // member variables (HAS A)
        public int score;
        public string name;
        public string choice;
        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock"};


        // constructor
        public Player()
        {
            score = 0;
        }



        // member methods

        public abstract void ChooseGesture();
        public abstract void ChooseName();





    }
}
