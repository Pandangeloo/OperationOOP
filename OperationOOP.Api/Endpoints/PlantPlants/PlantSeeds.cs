namespace OperationOOP.Api.Endpoints
{
    public class SeedPlants : IEndpoint
    {
        // Mapping för /plants/seed
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
            .MapPost("/plants/seed", Handle)
            .WithSummary("Seed test plants with random names, locations, and care levels.");

        private static IResult Handle(IDatabase db)
        {
            if (db.Plants.Any())
            {
                return Results.Ok("DemoPlants already exsists.");
            }

            var firstNames = new[] { "Bella", "Charlie", "Luna", "Max", "Milo", "Zara", "Oliver", "Ella", "Maya", "Leo" };
            var locations = new[] { "Living Room", "Kitchen", "Bedroom", "Office", "Garden", "Hallway", "Patio" };

            var testPlants = new List<(string Type, CareLevel CareLevel)>
    {
        ("Banksia", CareLevel.Intermediate),
        ("Bonsai", CareLevel.Advanced),
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
                        PlantName: $"{plant.Type} - {firstNames[random.Next(firstNames.Length)]} {random.Next(1, 40)}",
                        Location: locations[random.Next(locations.Length)],
                        AgeYears: random.Next(1, 10),
                        LastWatered: DateTime.Now.AddDays(-random.Next(1, 30)),
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
