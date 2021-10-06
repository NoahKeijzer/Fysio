using DataAccess.Data;
using DataAccess.LocalRepo;
using DataAccess.SQLRepo;
using Domain.DomainModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Presentation
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
            services.AddControllersWithViews();
            services.AddScoped<IRepo<Patient>, PatientRepo>();
            services.AddScoped<IRepo<Student>, StudentRepo>();
            services.AddScoped<ISQLRepo<Student>, SQLStudentRepo>();
            services.AddScoped<ISQLRepo<Patient>, SQLPatientRepo>();
            services.AddScoped<ISQLRepo<Physiotherapist>, SQLPhysiotherapistRepo>();
            services.AddScoped<ISQLRepo<Teacher>, SQLTeacherRepo>();
            services.AddRazorPages();
            services.AddDbContext<FysioDbContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("Default")));

            //services.AddIdentity<IdentityUser, IdentityRole>()
            //    .AddEntityFrameworkStores<SecurityDbContext>().AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Register}/{action=Register}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "/");
            });
        }
    }
}
