using OperationOOP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    public class Banksia : Plant , ILoveFire
    {
     
        public void FireSeeds(int temperatureC)
        {
            if (temperatureC >= 120)
            {
                Console.WriteLine("Kotten är tillräckligt varm och börjar öppna sig. Du kan få ut fröna."); 
            }
            if (temperatureC < 120)
            {
                Console.WriteLine("Det har inte blivit tillräckligt varmt för att Banksia ska släppa sin frön");
            };
        }
    }
}
