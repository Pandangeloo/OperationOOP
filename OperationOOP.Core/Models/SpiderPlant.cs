using OperationOOP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    public class SpiderPlant : Plant , ILoveHanging
    {
        
        public void HangFrom(HangingLocation location)
        {
            Console.WriteLine($"Ampelliljan hänger ifrån {location}");
        }
    }
}
