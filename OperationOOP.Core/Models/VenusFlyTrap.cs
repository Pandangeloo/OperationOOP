using OperationOOP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    public class VenusFlyTrap : Plant , ILoveMeat
    {
    public void Feed(string prey)
        {
            Console.WriteLine($"Denna köttätande växt behöver få äta på en {prey}");
        }
    }
}
