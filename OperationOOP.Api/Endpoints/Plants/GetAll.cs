namespace OperationOOP.Api.Endpoints;
public class GetAllPlants : IEndpoint
{
    // Mapping
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("/plants", Handle)
        .WithSummary("Important Info about the plants.");

    // Request and Response types
    public record Response(
        int Id,
        string Type,
        string PlantName,
        string Location,
        int AgeYears,
        string LastWatered,
        string CareLevel

    );

    //Logic
    private static List<Response> Handle(IDatabase db)
    {
        return db.Plants
            .Select(item => new Response(
                Id: item.Id,
                Type: item.Type,
                PlantName: item.PlantName,
                Location: item.Location,
                AgeYears: item.AgeYears,
                LastWatered: item.LastWatered.ToString("d"),
                CareLevel : item.CareLevel.ToString()
                
            )).ToList();
    }
}