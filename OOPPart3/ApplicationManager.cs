using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart3
{
    public class ApplicationManager
    {
        //Method injection
        public void DoApplication(ICar car, ILoggerService loggerService)
        {
            //
            // Codes
            //

            car.CalculateFuel();
            loggerService.Log();
        }

        public void DoApplication(ICar car, List<ILoggerService> loggerServices)
        {
            //
            // Codes
            //

            car.CalculateFuel();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void DoCarPreInformation(List<ICar> cars)
        {
            foreach (var car in cars)
            {
                car.CalculateFuel();
            }
        }
    }
}
