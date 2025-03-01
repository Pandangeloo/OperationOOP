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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int AgeYears { get; set; }
        public DateTime LastWatered { get; set; }
        public CareLevel CareLevel { get; set; }

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
