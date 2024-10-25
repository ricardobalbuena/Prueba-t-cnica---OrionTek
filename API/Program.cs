using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            

            if (app.Environment.IsDevelopment()) { 
                app.UseSwagger(); 
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1")); 
            }

            app.UseHttpsRedirection();
            app.MapControllers();

            app.Run();
        }
    }
}
