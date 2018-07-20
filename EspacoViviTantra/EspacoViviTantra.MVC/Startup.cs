using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.DAL.Repositories;
using EspacoViviTantra.MVC.Domain.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EspacoViviTantra.MVC
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsetting.json", optional:true, reloadOnChange:true)
                .AddJsonFile("config.json", optional: true, reloadOnChange: true);
        
            _configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var sqlConnection = _configuration.GetConnectionString("EspacoViviTantraDB");
            services.AddDbContext<EspacoViviTantraContext>(options => 
                options.UseMySql(sqlConnection, b => b.MigrationsAssembly("EspacoViviTantra")));
            services.AddMvc();
            services.AddScoped<IBairroRepository,BairroRepository>();
            services.AddScoped<ICidadeRepository,CidadeRepository>();
            services.AddScoped<IEnderecoRepository,EnderecoRepository>();
            services.AddScoped<IEstadoRepository,EstadoRepository>();
            services.AddScoped<IImagemRepository,ImagemRepository>();
            services.AddScoped<IPessoaRepository,PessoaRepository>();
            services.AddScoped<IPostRepository,PostRepository>();
            services.AddScoped<ITelefoneRepository,TelefoneRepository>();
            services.AddScoped<ITipoEnderecoRepository,TipoEnderecoRepository>();
            services.AddScoped<ITipoPostRepository,TipoPostRepository>();
            services.AddScoped<ITipoTelefoneRepository,TipoTelefoneRepository>();
            services.AddScoped<ITipoUsuarioRepository,TipoUsuarioRepository>();
            services.AddScoped<IUsuarioRepository,UsuarioRepository>();
            services.AddScoped<IUsuarioStatusRepository,UsuarioStatusRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
