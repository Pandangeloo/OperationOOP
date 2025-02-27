using OperationOOP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    internal class Passionflower : Plant , INeedClimbing
    {
        int Id { get; set; }
        string Name { get; set; }
        string Species { get; set; }
        int AgeYears { get; set; }
    }
}
