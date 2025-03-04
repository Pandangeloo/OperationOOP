using OperationOOP.Core.Data;
using OperationOOP.Core.Interfaces;
using OperationOOP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOOP.Core.MethodsAndFilter
{
    //Note to myself so i can learn this better. This service will ONLY handle the logics for my plants. That way we follow SRP. 

    //Implementing rules from IPlantService

    public class PlantService : IPlantService
    {
        private readonly IDatabase _database;

        public PlantService(IDatabase database)
        {
            _database = database;
        }

        public List<Plant> FilterByCareLevel(CareLevel level)
        {
            return _database.Plants.Where(p => p.CareLevel == level).ToList();
        }

        public List<Plant> GetPlantsNeedingWatering(int days)
        {
            DateTime needsWater = DateTime.Now.AddDays(-days);
            return _database.Plants.Where(p => p.LastWatered <needsWater).ToList();  
        }

        public List<Plant> SortByAge()
        {
            return _database.Plants.OrderBy(p => p.AgeYears).ToList();

        }

        public List<Plant> SortByName()
        {
            return _database.Plants.OrderBy(p => p.PlantName).ToList();
        }


    }
}
