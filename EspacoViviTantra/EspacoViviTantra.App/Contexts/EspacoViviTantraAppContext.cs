using EspacoViviTantra.Data.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantraApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EspacoViviTantra.App.Contexts
{
    public class EspacoViviTantraAppContext : EspacoViviTantraContext       
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;

        public EspacoViviTantraAppContext(DbContextOptions<EspacoViviTantraContext> options,EspacoViviTantraContext espacoViviTantraContext):base(options)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }

       /* public void ConfigureServices(IServiceCollection services)
        {
            /*var sqlConnection = _configuration.GetConnectionString("EspacoViviTantraDB");
            services.AddDbContext<EspacoViviTantraContext>(options => 
                options.UseMySql(sqlConnection, b => b.MigrationsAssembly("EspacoViviTantra.Data")));*/
            /*       
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

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }*/
    }
}