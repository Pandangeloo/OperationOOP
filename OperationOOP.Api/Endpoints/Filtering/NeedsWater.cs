using OperationOOP.Core.Interfaces;

namespace OperationOOP.Api.Endpoints.Filtering
{
    public class NeedsWater : IEndpoint
        {
            public static void MapEndpoint(IEndpointRouteBuilder app) => app
         .MapGet("/plants/filter/needsWater", Handle)
         .WithSummary("Get to know wich plants needs water first.");


            public record Response(

                string LastWatered,
                string Type,
                string PlantName,
                string Location               
                

             );

            private static List<Response> Handle(IPlantService plantService)
            {
                return plantService.GetPlantsNeedingWatering(7).Select(p => new Response(

                    p.LastWatered.ToString("d"),
                    p.Type,
                    p.PlantName,
                    p.Location

                    )).ToList();


            }
    
    }



    
}
