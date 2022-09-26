using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart3
{
    public class Audi : ICar
    {
        public void CalculateFuel()
        {
            Console.WriteLine("14 liters of gasoline were used for every 100 kilometers for Audi.");
        }
    }
}
