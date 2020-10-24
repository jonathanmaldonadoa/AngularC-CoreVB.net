using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using Solution.Api.CrossCutting.Register;
using Solution.Api.DataAccess;
using Solution.Api.DataAccess.Contracts;

namespace SolutionApi
{
    public class Startup
    {
        readonly string MyPolicy = "_myPolicy";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISolutionDBContext, SolutionDBContext>();
            services.AddDbContext<SolutionDBContext>(op => op.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection")));

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("EnableCors",
            //    builder =>
            //    {
            //        builder
            //        //.WithOrigins("http://localhost:4200")
            //        .AllowAnyOrigin()
            //        .AllowAnyHeader()
            //        .AllowAnyMethod()
            //        .AllowCredentials()
            //        .Build(); 
            //    });
            //});
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyPolicy,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                         .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                        //.WithHeaders(HeaderNames.ContentType, "x-custom-header")
                        //.WithMethods("PUT", "DELETE", "GET", "OPTIONS");
                    });
            });


            IoCRegister.AddRegistration(services);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseCors(MyPolicy);


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
