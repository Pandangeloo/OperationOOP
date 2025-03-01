namespace OperationOOP.Api.Endpoints;
public class CreatePlant : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapPost("/plants", Handle)
        .WithSummary("Create new plant");
        

    public record Request(
        string Type,
        string PlantName,
        string Location,
        int AgeYears,
        DateTime LastWatered,        
        CareLevel CareLevel,

        BonsaiStyle? Style,
        DateTime? LastPruned
        

        );
    public record Response(int id);

    public static IResult Handle(Request request, IDatabase db)
    {
        Plant? plant = request.Type.ToLower() switch
        {
            "banksia" => new Banksia
            {
                Type = request.Type,
                PlantName = request.PlantName,
                Location = request.Location,
                AgeYears = request.AgeYears,
                LastWatered = request.LastWatered,
                CareLevel = request.CareLevel
            },
            "bonsai" => new Bonsai
            {
                Type = request.Type,
                PlantName = request.PlantName,
                Location = request.Location,
                AgeYears = request.AgeYears,
                LastWatered = request.LastWatered,
                CareLevel = request.CareLevel,
                Style = request.Style ?? BonsaiStyle.Moyogi, 
                LastPruned = request.LastPruned ?? DateTime.Now,
            },
            "monstera" => new Monstera
            {
                Type = request.Type,
                PlantName = request.PlantName,                
                Location = request.Location,
                AgeYears = request.AgeYears,
                LastWatered = request.LastWatered,
                CareLevel = request.CareLevel
            },
            "passionflower" => new Passionflower
            {
                Type = request.Type,
                PlantName = request.PlantName,                
                Location = request.Location,
                AgeYears = request.AgeYears,
                LastWatered = request.LastWatered,
                CareLevel = request.CareLevel
            },
            "spiderplant" => new SpiderPlant
            {
                Type = request.Type,
                PlantName = request.PlantName,                
                Location = request.Location,
                AgeYears = request.AgeYears,
                LastWatered = request.LastWatered,
                CareLevel = request.CareLevel
            },
            "venusflytrap" => new VenusFlyTrap
            {
                Type = request.Type,
                PlantName = request.PlantName,                
                Location = request.Location,
                AgeYears = request.AgeYears,
                LastWatered = request.LastWatered,
                CareLevel = request.CareLevel
            },
            _ => null 
        };

        
        if (plant == null)
        {
            return Results.BadRequest(new { message = "Invalid plant type specified. Valid types are: Banksia, Bonsai, Monstera, Passionflower, Spiderplant, VenusFlytrap." });
        }

        plant.Id = db.Plants.Any()
            ? db.Plants.Max(plant => plant.Id) + 1
            : 1;
        
        db.Plants.Add(plant);

        return TypedResults.Ok(new Response(plant.Id));
    }
}

