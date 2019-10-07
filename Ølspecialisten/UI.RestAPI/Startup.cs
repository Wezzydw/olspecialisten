using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Ølspecialisten.Core.ApplicationServices;
using Ølspecialisten.Core.ApplicationServices.Services;
using Ølspecialisten.Core.DomainServices;
using Ølspecialisten.Core.Entity;
using Ølspecialisten.Infrastructure.Data;
using Ølspecialisten.Infrastructure.Data.Repositories;

namespace UI.RestAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors();

            services.AddScoped<IBeerRepository, BeerRepository>();
            services.AddScoped<IBeerService, BeerService>();
      
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

           
            services.AddDbContext<BeerContext>(opt =>
              opt.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            using (var scope = app.ApplicationServices.CreateScope())
            {
                // Initialize the database
                var services = scope.ServiceProvider;
                var dbContext = services.GetService<BeerContext>();
                var dbInitializer = services.GetService<DBInitializer>();
                dbInitializer.Initialize(dbContext);
            }
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseMvc();
        }
    }
}
