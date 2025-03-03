using OperationOOP.Core.Interfaces;

namespace OperationOOP.Api.Endpoints.Filtering
{
    public class FilterByMaster : IEndpoint
    {
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
       .MapGet("/plants/filter/carelevel/Master", Handle)
       .WithSummary("To see the plants in a certaion carelevel.");

        public record Response(

            string Type,
            string CareLevel,
            string Location



            );

        private static List<Response> Handle(IPlantService plantService)
        {
            return plantService.FilterByCareLevel(CareLevel.Master).Select(p => new Response(

                p.Type,
                p.CareLevel.ToString(),
                p.Location

                )).ToList();
        }


    }
}
