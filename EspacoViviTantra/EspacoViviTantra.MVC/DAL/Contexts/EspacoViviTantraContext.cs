
using EspacoViviTantra.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EspacoViviTantra.MVC.DAL.Contexts
{
    public class EspacoViviTantraContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<TipoUsuario> TiposUsuarios {get; set;}
        public DbSet<UsuarioStatus> UsuarioStatus {get; set;}
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<TipoPost> TiposPosts { get; set; }
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
            //Bairro
            modelBuilder.Entity<Bairro>().HasKey(b => b.Id);
            modelBuilder.Entity<Bairro>().Property(b => b.Nome).HasColumnType("varchar(50)");
            modelBuilder.Entity<Bairro>().Property(b => b.Nome).HasMaxLength(50);
            //Cidade
            modelBuilder.Entity<Cidade>().HasKey(c => c.Id);
            modelBuilder.Entity<Cidade>().Property(c => c.Nome).HasColumnType("varchar(50)");
            modelBuilder.Entity<Cidade>().Property(c => c.Nome).HasMaxLength(50);
            //Endereco
            modelBuilder.Entity<Endereco>().HasKey(e => e.Id);
            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro).HasColumnType("varchar(100)");
            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro).HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(e => e.Complemento).HasColumnType("varchar(50)");
            modelBuilder.Entity<Endereco>().Property(e => e.Complemento).HasMaxLength(50);
            modelBuilder.Entity<Endereco>().Property(e => e.Numero).HasColumnType("varchar(10)");
            modelBuilder.Entity<Endereco>().Property(e => e.Numero).HasMaxLength(10);
            modelBuilder.Entity<Endereco>().Property(e => e.Cep).HasColumnType("varchar(10)");
            modelBuilder.Entity<Endereco>().Property(e => e.Cep).HasMaxLength(10);
            //TipoEndereco
            modelBuilder.Entity<TipoEndereco>().HasKey(t => t.Id);
            modelBuilder.Entity<TipoEndereco>().Property(t => t.Descricao).HasColumnType("varchar(50)");
            modelBuilder.Entity<TipoEndereco>().Property(t => t.Descricao).HasMaxLength(50);
            //Estado
            modelBuilder.Entity<Estado>().HasKey(e => e.Id);
            modelBuilder.Entity<Estado>().Property(e => e.Nome).HasColumnType("varchar(100)");
            modelBuilder.Entity<Estado>().Property(e => e.Nome).HasMaxLength(100);
            //Imagem
            modelBuilder.Entity<Imagem>().HasKey(i => i.Id);
            modelBuilder.Entity<Imagem>().Property(i => i.Nome).HasColumnType("varchar(100)");
            modelBuilder.Entity<Imagem>().Property(i => i.Nome).HasMaxLength(100);
            modelBuilder.Entity<Imagem>().Property(i => i.Descricao).HasColumnType("varchar(100)");
            modelBuilder.Entity<Imagem>().Property(i => i.Descricao).HasMaxLength(100);
            modelBuilder.Entity<Imagem>().Property(i => i.Caminho).HasColumnType("varchar(150)");
            modelBuilder.Entity<Imagem>().Property(i => i.Caminho).HasMaxLength(150);
            //Pessoa
            modelBuilder.Entity<Pessoa>().HasKey(p => p.Id);
            modelBuilder.Entity<Pessoa>().Property(p => p.Nome).HasColumnType("varchar(150)");
            modelBuilder.Entity<Pessoa>().Property(p => p.Nome).HasMaxLength(150);
            modelBuilder.Entity<Pessoa>().Property(p => p.Sobrenome).HasColumnType("varchar(150)");
            modelBuilder.Entity<Pessoa>().Property(p => p.Sobrenome).HasMaxLength(150);
            modelBuilder.Entity<Pessoa>().Property(p => p.Email).HasColumnType("varchar(150)");
            modelBuilder.Entity<Pessoa>().Property(p => p.Email).HasMaxLength(150);
            modelBuilder.Entity<Pessoa>().Property(p => p.Rg).HasColumnType("varchar(13)");
            modelBuilder.Entity<Pessoa>().Property(p => p.Rg).HasMaxLength(13);
            modelBuilder.Entity<Pessoa>().Property(p => p.Cpf).HasColumnType("varchar(15)");
            modelBuilder.Entity<Pessoa>().Property(p => p.Cpf).HasMaxLength(15);
            //Post
            modelBuilder.Entity<Post>().HasKey(p => p.Id);
            modelBuilder.Entity<Post>().Property(p => p.Titulo).HasColumnType("varchar(100)");
            modelBuilder.Entity<Post>().Property(p => p.Titulo).HasMaxLength(100);
            modelBuilder.Entity<Post>().Property(p => p.Descricao).HasColumnType("varchar(150)");
            modelBuilder.Entity<Post>().Property(p => p.Descricao).HasMaxLength(150);
            //TipoPost
            modelBuilder.Entity<TipoPost>().HasKey(t => t.Id);
            modelBuilder.Entity<TipoPost>().Property(t => t.Descricao).HasColumnType("varchar(50)");
            modelBuilder.Entity<TipoPost>().Property(t => t.Descricao).HasMaxLength(50);
            //Telefone
            modelBuilder.Entity<Telefone>().HasKey(t => t.Id);
            modelBuilder.Entity<Telefone>().Property(t => t.Numero).HasColumnType("varchar(15)");
            modelBuilder.Entity<Telefone>().Property(t => t.Numero).HasMaxLength(15);
            //TipoTelefone
            modelBuilder.Entity<TipoTelefone>().HasKey(t => t.Id);
            modelBuilder.Entity<TipoTelefone>().Property(t => t.Descricao).HasColumnType("varchar(50)");
            modelBuilder.Entity<TipoTelefone>().Property(t => t.Descricao).HasMaxLength(50);
            
            //Usuario
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<Usuario>().Property(u => u.Login).HasColumnType("varchar(150)");
            modelBuilder.Entity<Usuario>().Property(u => u.Login).HasMaxLength(150);
            modelBuilder.Entity<Usuario>().Property(u => u.Password).HasColumnType("varchar(32)");
            modelBuilder.Entity<Usuario>().Property(u => u.Password).HasMaxLength(32);
            //TipoUsuario
            modelBuilder.Entity<TipoUsuario>().HasKey(t => t.Id);
            modelBuilder.Entity<TipoUsuario>().Property(t => t.Descricao).HasColumnType("varchar(50)");
            modelBuilder.Entity<TipoUsuario>().Property(t => t.Descricao).HasMaxLength(50);
            //UsuarioStatus
            modelBuilder.Entity<UsuarioStatus>().HasKey(u => u.Id);
            modelBuilder.Entity<UsuarioStatus>().Property(u => u.Descricao).HasColumnType("varchar(50)");
            modelBuilder.Entity<UsuarioStatus>().Property(u => u.Descricao).HasMaxLength(50);
            //Primary Keys
        
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}