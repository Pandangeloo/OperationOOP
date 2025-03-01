using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Interfaces
{
    public interface ILoveHanging
    {

        void HangFrom(HangingLocation location);

    }

    public enum HangingLocation
    {
        Window,
        Wall, 
        Ceiling,
        Shelf,
        Balcony        
    }

}
