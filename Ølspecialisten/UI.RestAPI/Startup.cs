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
using Newtonsoft.Json.Converters;
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
        public Startup(IConfiguration configuration,IHostingEnvironment env)
        {
            Configuration = configuration;
            this.env = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment env { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors();

            if (env.IsDevelopment())
            {
                // In-memory database:
                services.AddDbContext<BeerContext>(opt => opt.UseSqlite("Data Source=Beers.db"));
            }
            else
            {
                // Azure SQL database:
                //services.AddDbContext<BeerContext>(opt =>
                //  opt.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));

                services.AddDbContext<BeerContext>(opt => opt.UseSqlite("Data Source=Beers.db"));
            }

            services.AddScoped<IBeerRepository, BeerRepository>();
            services.AddScoped<IBeerService, BeerService>();
            services.AddTransient<IDBInitializer, DBInitializer>();
            services.AddMvc().AddJsonOptions(options => {
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
            });
           
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            using (var scope = app.ApplicationServices.CreateScope())
            {
                // Initialize the database
                var services = scope.ServiceProvider;
                var dbContext = services.GetService<BeerContext>();
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
                var dbInitializer = services.GetService<IDBInitializer>();
                dbInitializer.Initialize(dbContext);
            }

            app.UseDeveloperExceptionPage();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            
            app.UseHttpsRedirection();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseMvc();
        }
    }
}
