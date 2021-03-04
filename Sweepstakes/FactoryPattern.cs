using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class FactoryPattern
    {
        public static ISweepstakesManager ChooseSweepstakesManager()
        {
            string UserInterface.UserInput("Choose preferred sweepstakes manager:\nFor stack style - Press '1'\nFor queue style - Press '2'");
            switch (userInput)
            {
                case "1":
                    return new SweepstakesStackManager();

                case "2":
                    return new SweepstakesQueueManager();
   
                default:
                    throw new Exception("Enter Valid Input");
            }
        }
    }
}
