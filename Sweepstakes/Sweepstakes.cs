using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        static Contestant contestant;
        public static string sweepstakesName;
        private Random random;
        int winner;
        Contestant contestantWinner;

        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();


        public void CreateContestant()
        {
            contestant = new Contestant();
            contestants.Add(contestant.registrationNumber, contestant);

        }

        public void CreateSweepstakes()
        {

            sweepstakesName = UserInterface.NameSweepstakes();

        }















    }
}
