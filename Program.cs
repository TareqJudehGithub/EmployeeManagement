using EmployeeManagement.Models.Implementation;
using EmployeeManagement.Models.Interfaces;

namespace EmployeeManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // register services in the dependency injection container
            #region Services
            builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

            // IEmployeeRespository will be implemented by MockEmployeeRepository class.
            builder.Services.AddSingleton<IEmployeeRespository, MockEmployeeRepository>();
            #endregion

            var app = builder.Build();

            #region Middleware(s)
            // Check if the environment is development - register developer middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Register middleware for using static files in ASP .Net;
            app.UseStaticFiles();

            // AddMvc() service middleware:
            app.UseMvcWithDefaultRoute();
            #endregion

            app.Run();
        }
    }
}
