using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;
        public void MarketingFirmActions()
        {
            while (true)
            {
                switch (UserInterface.GetMarketingFirmAction())
                {
                    case "1":
                        FactoryPattern.ChooseSweepstakesManager();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        MarketingFirmActions();
                        break;
                }
            }
        }
    }
}
