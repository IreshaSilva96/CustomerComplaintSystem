using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Interfaces;
using CustomerComplaintSystem.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CustomerComplaintSystem
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
            services.AddControllers();

            //Cors Enable
            services.AddCors(options =>
            {
                options.AddPolicy("MyAllowSpecificOrigins",
                    builder =>
                    builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin());
            });

            //Cors end

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IAccountInterface, AccountRepository>();
            services.AddScoped<IAccountHolderInterface, AccountHolderRepository>();
            services.AddScoped<IAccountTypeInterface, AccountTypeRepository>();
            services.AddScoped<IAgentInterface, AgentRepository>();
            services.AddScoped<IAgentTypeInterface, AgentTypeRepository>();
            services.AddScoped<IBranchInterface, BranchRepository>();
            services.AddScoped<IComplaintInterface, ComplaintRepository>();
            services.AddScoped<ICategoryOfComplaintInterface, CategoryOfComplaintRepository>();
            services.AddScoped<IComplaintStatusInterface, ComplaintStatusRepository>();
            services.AddScoped<ICustomerTypeInterface, CustomerTypeRepository>();
            services.AddScoped<IEmployeeInterface, EmployeeRepository>();
            services.AddScoped<INatureOfComplaintInterface, NatureOfComplaintRepository>();
            services.AddScoped<IProductAndServiceInterface, ProductAndServiceRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("MyAllowSpecificOrigins");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
