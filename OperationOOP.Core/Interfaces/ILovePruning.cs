using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Interfaces
{
    public interface ILovePruning

    {
        DateTime LastPruned { get; set; }
        void ChangeStyle(BonsaiStyle bonsaiStyle);
    }


    public enum BonsaiStyle
    {
        Chokkan,    // Formal Upright
        Moyogi,     // Informal Upright
        Shakan,     // Slanting
        Kengai,     // Cascade
        HanKengai   // Semi-cascade
    }

}
