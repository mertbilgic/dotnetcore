﻿using System;
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

namespace MovieApp
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
            
            //wwwroot => /css/style.css
            app.UseStaticFiles(); 

            //modules/bootstrap/dist/css/bootstrap.min.css
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider = new PhysicalFileProvider(Path.Combine
                (Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath ="/modules"
            });

            //Bu koşul sadece geliştirme aşamasında olan bir işlem
            //Aldığımız hataları detaylı bir şekilde gösterilmesi için
            //kullanılyıor
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //home/index/3
            app.UseMvcWithDefaultRoute();

        }
    }
}
