using OperationOOP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.Interfaces
{
    //Rules for classes
    public interface IPlantService
    {
        List<Plant> FilterByCareLevel(CareLevel level);
        List<Plant> FilterBySpecies(string species);
        List<Plant> SortByAge();
        List<Plant> SortByName();
        List<Plant> GetPlantsNeedingWatering(int days);


    }
}
