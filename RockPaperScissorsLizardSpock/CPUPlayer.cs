using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class CPUPlayer : Player
    {
        // member variables (HAS A)
        private Random rand;
        public int gesturesCount;


        // constructor

        public CPUPlayer()
        {
            rand = new Random();
            gesturesCount = gestures.Count;
        }


        // member methods

        public override void ChooseGesture()
        {
            int CPUChoice = rand.Next(gesturesCount);
            choice = gestures[CPUChoice];
            Console.WriteLine(choice);
        }

        public override void ChooseName()
        {
            name = "Computador";
        }
    }
}
