
using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }

        //services.AddMvc();
            var sqlConnection = _configuration.GetConnectionString("EspacoViviTantraDB");
            services.AddDbContext<EspacoViviTantraContext>(options => 
                options.UseMySql(sqlConnection, b => b.MigrationsAssembly("EspacoViviTantra.Data")));

        base.OnModelCreating(modelBuilder);
    }
}
