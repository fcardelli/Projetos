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
            modelBuilder.Entity<Bairro>().Property(b => b.Nome).HasColumnType("varchar");
            modelBuilder.Entity<Bairro>().Property(b => b.Nome).HasMaxLength(50);
            //Cidade
            modelBuilder.Entity<Cidade>().HasKey(c => c.Id);
            modelBuilder.Entity<Cidade>().Property(c => c.Nome).HasColumnType("varchar");
            modelBuilder.Entity<Cidade>().Property(c => c.Nome).HasMaxLength(50);
            //Endereco
            modelBuilder.Entity<Endereco>().HasKey(e => e.Id);
            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro).HasColumnType("varchar");
            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro).HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(e => e.Complemento).HasColumnType("varchar");
            modelBuilder.Entity<Endereco>().Property(e => e.Complemento).HasMaxLength(50);
            modelBuilder.Entity<Endereco>().Property(e => e.Numero).HasColumnType("varchar");
            modelBuilder.Entity<Endereco>().Property(e => e.Numero).HasMaxLength(10);
            modelBuilder.Entity<Endereco>().Property(e => e.Cep).HasColumnType("varchar");
            modelBuilder.Entity<Endereco>().Property(e => e.Cep).HasMaxLength(10);
            //TipoEndereco
            modelBuilder.Entity<TipoEndereco>().HasKey(t => t.Id);
            modelBuilder.Entity<TipoEndereco>().Property(t => t.Descricao).HasColumnType("varchar");
            modelBuilder.Entity<TipoEndereco>().Property(t => t.Descricao).HasMaxLength(50);
            //Estado
            modelBuilder.Entity<Estado>().HasKey(e => e.Id);
            modelBuilder.Entity<Estado>().Property(e => e.Nome).HasColumnType("varchar");
            modelBuilder.Entity<Estado>().Property(e => e.Nome).HasMaxLength(100);
            //Imagem
            modelBuilder.Entity<Imagem>().HasKey(i => i.Id);
            modelBuilder.Entity<Imagem>().Property(i => i.Nome).HasColumnType("varchar");
            modelBuilder.Entity<Imagem>().Property(i => i.Nome).HasMaxLength(100);
            modelBuilder.Entity<Imagem>().Property(i => i.Descricao).HasColumnType("varchar");
            modelBuilder.Entity<Imagem>().Property(i => i.Descricao).HasMaxLength(100);
            modelBuilder.Entity<Imagem>().Property(i => i.Caminho).HasColumnType("varchar");
            modelBuilder.Entity<Imagem>().Property(i => i.Caminho).HasMaxLength(150);
            //Pessoa
            modelBuilder.Entity<Pessoa>().HasKey(p => p.Id);
            modelBuilder.Entity<Pessoa>().Property(p => p.Nome).HasColumnType("varchar");
            modelBuilder.Entity<Pessoa>().Property(p => p.Nome).HasMaxLength(150);
            modelBuilder.Entity<Pessoa>().Property(p => p.Sobrenome).HasColumnType("varchar");
            modelBuilder.Entity<Pessoa>().Property(p => p.Sobrenome).HasMaxLength(150);
            modelBuilder.Entity<Pessoa>().Property(p => p.Email).HasColumnType("varchar");
            modelBuilder.Entity<Pessoa>().Property(p => p.Email).HasMaxLength(150);
            modelBuilder.Entity<Pessoa>().Property(p => p.Rg).HasColumnType("varchar");
            modelBuilder.Entity<Pessoa>().Property(p => p.Rg).HasMaxLength(13);
            modelBuilder.Entity<Pessoa>().Property(p => p.Cpf).HasColumnType("varchar");
            modelBuilder.Entity<Pessoa>().Property(p => p.Cpf).HasMaxLength(15);
            //Post
            modelBuilder.Entity<Post>().HasKey(p => p.Id);
            modelBuilder.Entity<Post>().Property(p => p.Titulo).HasColumnType("varchar");
            modelBuilder.Entity<Post>().Property(p => p.Titulo).HasMaxLength(100);
            modelBuilder.Entity<Post>().Property(p => p.Descricao).HasColumnType("varchar");
            modelBuilder.Entity<Post>().Property(p => p.Descricao).HasMaxLength(150);
            //TipoPost
            modelBuilder.Entity<TipoPost>().HasKey(t => t.Id);
            modelBuilder.Entity<TipoPost>().Property(t => t.Descricao).HasColumnType("varchar");
            modelBuilder.Entity<TipoPost>().Property(t => t.Descricao).HasMaxLength(50);
            //Telefone
            modelBuilder.Entity<Telefone>().HasKey(t => t.Id);
            modelBuilder.Entity<Telefone>().Property(t => t.Numero).HasColumnType("varchar");
            modelBuilder.Entity<Telefone>().Property(t => t.Numero).HasMaxLength(15);
            //TipoTelefone
            modelBuilder.Entity<TipoTelefone>().HasKey(t => t.Id);
            modelBuilder.Entity<TipoTelefone>().Property(t => t.Descricao).HasColumnType("varchar");
            modelBuilder.Entity<TipoTelefone>().Property(t => t.Descricao).HasMaxLength(50);
            
            //Usuario
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<Usuario>().Property(u => u.Password).HasColumnType("varchar");
            modelBuilder.Entity<Usuario>().Property(u => u.Password).HasMaxLength(32);
            //TipoUsuario
            modelBuilder.Entity<TipoUsuario>().HasKey(t => t.Id);
            //UsuarioStatus
            modelBuilder.Entity<UsuarioStatus>().HasKey(t => t.Id);
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