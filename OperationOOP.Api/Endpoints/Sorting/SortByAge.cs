using OperationOOP.Core.Interfaces;

namespace OperationOOP.Api.Endpoints.Sorting
{
    public class SortByAge : IEndpoint
    {
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
     .MapGet("/plants/sort/age", Handle)
     .WithSummary("Sort by the plants age.");


        public record Response(
            
            int Age,
            string Type,
            string PlantName,
            int Id

         );

        private static List<Response> Handle(IPlantService plantService)
        {
            return plantService.SortByAge().Select(p => new Response(
                
                p.AgeYears,
                p.Type,
                p.PlantName,
                p.Id
                )).ToList();


        }
    }
}
