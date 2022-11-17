using Luxury_Back.DB;
using Luxury_Back.EmailServices;
using Luxury_Back.EmailSetting;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Configuration;
using System.Globalization;
using System.Text.Json.Serialization;


namespace Luxury_Back
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region language
            builder.Services.AddLocalization();
            builder.Services.AddSingleton<IStringLocalizerFactory, JsonStringLocalizerFactory>();
            builder.Services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(Options =>
                {
                    Options.DataAnnotationLocalizerProvider = (Type, factory) => factory.Create(typeof(JsonStringLocalizerFactory));
                });
            builder.Services.Configure<RequestLocalizationOptions>(Options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo(name:"en-US"),
                     new CultureInfo(name:"ar-EG")

                };
                Options.DefaultRequestCulture = new RequestCulture(culture: supportedCultures[0], uiCulture: supportedCultures[0]);

                Options.SupportedCultures = supportedCultures;
                Options.SupportedUICultures = supportedCultures;

            });
            #endregion

            #region MailSettings To Read Data In appsettings
            
           // builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

            #endregion

            #region Inject MailingServices
          //  builder.Services.AddTransient<IMailingService,MailingService>();
            #endregion

            builder.Services.AddControllers()
               .AddJsonOptions(o => o.JsonSerializerOptions
                   .ReferenceHandler = ReferenceHandler.IgnoreCycles);

            builder.Services.AddDbContext<LuxuryDb>(db =>
            {
                db.UseSqlServer(builder.Configuration.GetConnectionString("luxuryDB"));
            });

            builder.Services.AddAuthentication("adminAuth")
                .AddCookie("adminAuth", auth =>
                {
                    auth.LoginPath = "/admin/auth/login";
                    auth.LogoutPath = "/admin/auth/logout";
                    auth.AccessDeniedPath = "/admin/auth/login";
                });
 
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            #region Language
            var supportedCultures = new[] { "en-US", "ar-EG" };
            var LocalizationOptions = new RequestLocalizationOptions()
                .SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            app.UseRequestLocalization(LocalizationOptions);
            #endregion

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapAreaControllerRoute(
                name: "Admin",
                areaName: "Admin",
                pattern: "admin/{controller=Home}/{action=Index}/{id?}");
            
            app.MapAreaControllerRoute(
                name: "Root",
                areaName: "Root",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            /*app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Index}/{action=Index}/{id?}");*/

            app.Run();
        }
    }
}