﻿namespace OperationOOP.Api.Endpoints
{
    public class CreateDemoPlants : IEndpoint
    {
        // Mapping för /plants/seed
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
            .MapPost("/plants/AddDemoPlants", Handle)
            .WithSummary("Seed test plants with random names, locations, and care levels.");

        private static IResult Handle(IDatabase db)
        {
            if (db.Plants.Any())
            {
                return Results.Ok("DemoPlants already exsists.");
            }

            var firstNames = new[] { "Lily", "Violetta", "Dahlia", "Astra", "Aspen", "Clemens", "Basil", "Bella", "Charlie", "Luna", "Max", "Milo", "Zara", "Oliver", "Ella", "Maya", "Leo" , "Jan-Åke", "Maj-Lis", "Britta" , "Bosse", "Anakonda", "Vissla", "Mårran", "Greger"};
            var locations = new[] { "Living Room", "Kitchen", "Bedroom", "Office", "Garden", "Hallway", "Patio" };

            var testPlants = new List<(string Type, CareLevel CareLevel)>
    {
        ("Banksia", CareLevel.Master),
        ("Bonsai", CareLevel.Master),
        ("Monstera", CareLevel.Beginner),
        ("Passionflower", CareLevel.Intermediate),
        ("Spiderplant", CareLevel.Beginner),
        ("Venusflytrap", CareLevel.Advanced)
    };

            var random = new Random();

            foreach (var plant in testPlants)
            {
                for (int i = 0; i < 5; i++)
                {
                    var request = new CreatePlant.Request(
                        Type: plant.Type,
                        PlantName: $"{firstNames[random.Next(firstNames.Length)]}",
                        Location: locations[random.Next(locations.Length)],
                        AgeYears: random.Next(1, 10),
                        LastWatered: DateTime.Now.AddDays(-random.Next(1, 10)),
                        CareLevel: plant.CareLevel,
                        Style: plant.Type == "Bonsai" ? BonsaiStyle.Moyogi : null,
                        LastPruned: plant.Type == "Bonsai" ? DateTime.Now.AddDays(-random.Next(1, 30)) : null
                    );

                    var result = CreatePlant.Handle(request, db);

                    if (result is Ok<CreatePlant.Response> okResult)
                    {
                        var plantId = okResult.Value.id;
                        Console.WriteLine($"Plant added with ID: {plantId}");
                    }
                }
            }

            return Results.Ok("DemoPlants Added.");
        }
    }
}
