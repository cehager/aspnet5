using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheWorld.Services;
using Microsoft.Extensions.PlatformAbstractions;
using TheWorld.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using TheWorld.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authentication.Cookies;
using System.Threading.Tasks;
using System.Net;

namespace TheWorld
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;

        public Startup(IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(config =>
            {
#if !DEBUG
                config.Filters.Add(new RequireHttpsAttribute());
#endif
            })
            .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });

            services.AddIdentity<WorldUser, IdentityRole>(config =>
             {
                 config.User.RequireUniqueEmail = true;
                 config.Password.RequireNonLetterOrDigit = false;
                 config.Password.RequireUppercase = false;
                 config.Password.RequiredLength = 6;
                 config.Cookies.ApplicationCookie.LoginPath = "/Auth/Login"; //if not vaild login go to a page
                 config.Cookies.ApplicationCookie.Events = new CookieAuthenticationEvents()
                 {
                     //ctx = context of the request/response
                     OnRedirectToLogin = ctx =>
                     {
                         if (ctx.Request.Path.StartsWithSegments("/api") && 
                           ctx.Response.StatusCode == (int) HttpStatusCode.OK)
                         {
                             ctx.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                         }
                         else
                         {
                             ctx.Response.Redirect(ctx.RedirectUri); //this is the default behavior
                         }

                         return Task.FromResult(0);
                     }
                 };
             }).AddEntityFrameworkStores<WorldContext>();

            services.AddLogging();

            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<WorldContext>();

            services.AddScoped<CoordService>();
            //services.AddScoped<WorldContextSeedData>(); //reuse an instance of the context
            services.AddTransient<WorldContextSeedData>(); //create a new instance of the context once

            services.AddScoped<IWorldRepository, WorldRepository>();


#if DEBUG
            services.AddScoped<IMailService, DebugMailService>();
#else
            services.AddScoped<IMailService, MailService>();
#endif
        }

        // This method gets called by the runtime.
        //Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, WorldContextSeedData seeder, ILoggerFactory loggerFactory)
        {

            loggerFactory.AddDebug(LogLevel.Warning);
            //app.UseDefaultFiles();
            app.UseStaticFiles(); //order matters in middleware
            app.UseIdentity();

            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Trip, TripViewModel>().ReverseMap();
                config.CreateMap<Stop, StopViewModel>().ReverseMap();

            });

            app.UseMvc(config => {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "index" }
                    );
            }); //looks for requests in the style of mvc

            await seeder.EnsureSeedDataAsync();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
