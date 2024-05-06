using Microsoft.EntityFrameworkCore;
using Services.Services;

namespace EntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Only one service instance across application lifetime
            builder.Services.AddSingleton<IServiceTest, FirstService>();

            // New Instance every time its requested
            //builder.Services.AddTransient<IServiceTest, FirstService>();

            // Single Service across the entire instance request
            //builder.Services.AddScoped<IServiceTest, FirstService>();

            var app = builder.Build();

            var service = app.Services.GetService<FirstService>();
            service.LogMessage("Test Message Log");
            service.PrintTypeName();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
