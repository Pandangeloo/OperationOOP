using OperationOOP.Core.Interfaces;
using System.Linq;

namespace OperationOOP.Api.Endpoints.Filtering
{
    public class FilterByBeginner : IEndpoint
    {
        //mapping

        public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("/plants/filter/carelevel/Beginner", Handle)
        .WithSummary("To see the plants in a certaion carelevel.");

        public record Response(
            
            string Type,
            string CareLevel,
            string Location
                  
            
            );

        private static List<Response> Handle(IPlantService plantService)
        {
            return plantService.FilterByCareLevel(CareLevel.Beginner).Select(p => new Response(
                
                p.Type,
                p.CareLevel.ToString(),
                p.Location
                
                )).ToList();
        }


    }
}
