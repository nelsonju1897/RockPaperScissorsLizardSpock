using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class HumanPlayer : Player
    {
        // member variables (HAS A)



        // constructor



        // member methods

        public override void ChooseGesture()
        {
            Console.WriteLine(name + " Choose gesture: Rock, Paper, Scissors, Lizard, or Spock.");
            choice = Console.ReadLine();
            Console.WriteLine("You chose:" + choice);
            //have cw state player1 or player 2 instead
            Console.ReadLine();
        }

        public override void ChooseName()
        {
            Console.WriteLine("Choose Name");
            name = Console.ReadLine();
            Console.WriteLine("Your name is:" + name);
        }




    }
}
