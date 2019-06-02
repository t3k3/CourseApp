using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace CourseApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()

                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //metod ile default olarak wwwroot klasörü dışarıya açılır.
            //wwwroot klasöründe img/ css /js gibi dosyalar bulunabilir
            app.UseStaticFiles();

            /*Spesifik dosya dışarıya açmak için metoda parametre veririz. Directory.GetCurrentDirectory bize ana dizini 
            verir. İkinci parametre klasörü gösteriyor. Sonuç olarak "bulunduğumuz_klasor/node_modules" döndürecektir.
            Devamında RequestPath = "/modules" yazarak node_modules ismini "modules" olarak değiştiriyoruz. */
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = "/modules"
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // localhost:5000/course/list
            // localhost:5000/course/dataist/1
            //routing

            // localhost:5000/course/list
            // localhost:5000/course/details/5
            // app.UseMvcWithDefaultRoute();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name : "default",
                    template : "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
