
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Options;

using OperationOOP.Api.Endpoints;
using OperationOOP.Core.Data;
using OperationOOP.Core.Interfaces;
using OperationOOP.Core.MethodsAndFilter;
using System.Text.Json.Serialization;

namespace OperationOOP.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {   
                
                options.CustomSchemaIds(type => type.FullName?.Replace('+', '.'));
                options.InferSecuritySchemes();
                
            });

            builder.Services.AddSingleton<IDatabase, Database>();
            builder.Services.AddSingleton<IPlantService, PlantService>();
            builder.Services.Configure<JsonOptions>(options =>
            {
                options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                        c.DefaultModelsExpandDepth(-1) //Remove visibility on schemas in swagger ui
                    );
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapEndpoints<Program>();

            app.Run();
        }
    }
}
