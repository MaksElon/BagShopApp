﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Repositories;
using MyOwnApp.Services;


namespace MyOwnApp
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<EFContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("BagConnection")));

            services.AddIdentity<User, Role>(options => options.Stores.MaxLengthForKeys = 128)
                .AddEntityFrameworkStores<EFContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                    options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });

            services.AddTransient<IProducts, ProductRepository>();
            services.AddTransient<IUsers, UserRepository>();
            services.AddTransient<IUserProfiles, UserProfileRepository>();
            services.AddTransient<IOrders, OrderRepository>();
            services.AddTransient<IProductOrders, ProductOrderRepository>();
            services.AddTransient<IProducers, ProducerRepository>();
            services.AddTransient<IProductModels, ProductModelRepository>();
            services.AddTransient<IProductImages, ProductImageRepository>();
            services.AddTransient<IMaterials, MaterialRepository>();
            services.AddTransient<IReviews, ReviewRepository>();
            services.AddTransient<IDimensions, DimensionRepository>();
            services.AddTransient<ITypeOfProducts, TypeOfProductRepository>();
            services.AddTransient<ISubCategories, SubCategoryRepository>();
            services.AddTransient<IDeliveries, DeliveryRepository>();
            services.AddTransient<ILikes, LikeRepository>();
            services.AddTransient<IDislikes, DislikeRepository>();

            services.AddMemoryCache();
            services.AddSession();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            string fileDestStr = env.ContentRootPath;
            fileDestStr = Path.Combine(fileDestStr, "Uploaded");
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(fileDestStr),
                RequestPath = new PathString("/Telesyk")
            });

            app.UseSession();

            await SeedDB.SeedData(app.ApplicationServices, env, this.Configuration);
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    // Name of the new route, we'll need it later to generate URLs in the templates
                    name: "twoids",
                    // Route pattern
                    template: "{controller}/{id}/{action}/{name}");
                
        });
        }
    }
}
