using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantraApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EspacoViviTantra.App
{
    public class Startup
    {
        /*public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        */
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
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
            app.UseStaticFiles();
            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
