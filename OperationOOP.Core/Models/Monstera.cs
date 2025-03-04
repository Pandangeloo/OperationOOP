using OperationOOP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Models
{
    public class Monstera : Plant , ILoveClimbing
    {

     public void Climb(string supportType)
        {
            Console.WriteLine($"Monsteran behöver få slingra sig på en {supportType}");
        }
    }
}
