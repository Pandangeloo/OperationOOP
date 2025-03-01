using OperationOOP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    public class Passionflower : Plant , ILoveClimbing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int AgeYears { get; set; }
        public DateTime LastWatered { get; set; }
        public CareLevel CareLevel { get; set; }

        public void Climb(string supportType)
        {
            Console.WriteLine($"{Name}n behöver få slingra sig på en {supportType}"); 
        }
    }
}
