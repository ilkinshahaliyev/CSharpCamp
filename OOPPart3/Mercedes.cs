using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart3
{
    public class Mercedes : ICar
    {
        public void CalculateFuel()
        {
            Console.WriteLine("16 liters of gasoline were used for every 100 kilometers for Mercedes.");
        }
    }
}
