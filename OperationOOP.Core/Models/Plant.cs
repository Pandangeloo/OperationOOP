using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    public abstract class Plant
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string PlantName { get; set; }
        
        public string Location { get; set; }
        public int AgeYears { get; set; }
        public DateTime LastWatered { get; set; }
        public CareLevel CareLevel { get; set; }
       
    }
     public enum CareLevel
        {
            Beginner,
            Intermediate,
            Advanced,
            Master
        }
}
