using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    public abstract class Plant
    {
        int Id { get; set; }
        string Name { get; set; }
        string Species { get; set; }
        int AgeYears { get; set; }


        public enum CareLevel
        {
            Beginner,
            Intermediate,
            Advanced,
            Master
        }
    }
}
