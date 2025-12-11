using DataAccess.Library;
using DataAccess.Library.Services;
using Microsoft.EntityFrameworkCore;
using WaterDropAppUI.Models;
using WaterDropUI.Components;

namespace WaterDropUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //register in-memory connection
            builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseInMemoryDatabase(builder.Configuration.GetConnectionString("TestDB")));

            //register services to access DB
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IValueService, ValueService>();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
