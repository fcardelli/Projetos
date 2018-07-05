using Microsoft.EntityFrameworkCore;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Data.Contexts
{
    public class EspacoViviTantraContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<TipoUsuario> TiposUsuarios {get; set;}
        public DbSet<UsuarioStatus> UsuarioStatus {get; set;}
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<TipoEndereco> TiposEnderecos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoTelefone> TiposTelefones { get; set; }
        
        public EspacoViviTantraContext(DbContextOptions<EspacoViviTantraContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Modelagem de Entidades

            //Primary Keys
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<Pessoa>().HasKey(p => p.Id);
            modelBuilder.Entity<Imagem>().HasKey(i => i.Id);
            modelBuilder.Entity<Post>().HasKey(p => p.Id);
            modelBuilder.Entity<Bairro>().HasKey(b => b.Id);
            modelBuilder.Entity<Cidade>().HasKey(c => c.Id);
            modelBuilder.Entity<Estado>().HasKey(e => e.Id);
            modelBuilder.Entity<Endereco>().HasKey(e => e.Id);
            modelBuilder.Entity<Telefone>().HasKey(t => t.Id);
            //

            //Usuario
            modelBuilder.Entity<Usuario>().Property(u => u.Password).HasColumnType("varchar");
            modelBuilder.Entity<Usuario>().Property(u => u.Password).HasMaxLength(32);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}