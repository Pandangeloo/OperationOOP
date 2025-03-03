namespace OperationOOP.Api.Endpoints.Filtering
{
    public class FilterClimbingPlants : IEndpoint
    {
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
    .MapGet("/plants/{id}", Handle)
    .WithSummary("Plant Id");

        public record Request(int Id);

        public record Response(
            int Id,
            string Type,
            string PlantName,
            string Location,
            int AgeYears,
            DateTime LastWatered,
            CareLevel CareLevel
        );

        private static Response Handle([AsParameters] Request request, IDatabase db)
        {
            var plant = db.Plants.Find(plant => plant.Id == request.Id);

            var response = new Response(
                     Id: plant.Id,
                     Type: plant.Type,
                     PlantName: plant.PlantName,
                     Location: plant.Location,
                     AgeYears: plant.AgeYears,
                     LastWatered: plant.LastWatered,
                     CareLevel: plant.CareLevel
                 );

            return response;
        }


    }
}
