using OperationOOP.Core.Interfaces;

namespace OperationOOP.Api.Endpoints;
public class SortByName : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("/plants/sort/name", Handle)
        .WithSummary("Sort by the plants name.");


    public record Response(
        int Id,
        string Type,
        string PlantName
     );

    private static List<Response> Handle(IPlantService plantService)
    {
        return plantService.SortByName().Select(p => new Response(
            p.Id,
            p.Type,
            p.PlantName
            )).ToList();


    }
}