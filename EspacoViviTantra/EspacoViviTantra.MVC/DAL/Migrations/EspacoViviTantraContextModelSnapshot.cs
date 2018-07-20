﻿// <auto-generated />
using EspacoViviTantra.MVC.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace EspacoViviTantra.Data.Migrations
{
    [DbContext(typeof(EspacoViviTantraContext))]
    partial class EspacoViviTantraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Bairro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Bairros");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BairroId");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("CidadeId");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("EstadoId");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("TipoId");

                    b.HasKey("Id");

                    b.HasIndex("BairroId");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("TipoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caminho")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Rg")
                        .HasColumnType("varchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("Sobrenome")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<int?>("TelefoneId");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<int?>("ImagemId");

                    b.Property<int?>("PessoaId");

                    b.Property<int?>("TipoId");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ImagemId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TipoId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<int?>("TipoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.TipoEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TiposEnderecos");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.TipoPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TiposPosts");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.TipoTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TiposTelefones");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.TipoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TiposUsuarios");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Login")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("PessoaId");

                    b.Property<int?>("StatusId");

                    b.Property<int?>("TipoId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TipoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.UsuarioStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("UsuarioStatus");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Endereco", b =>
                {
                    b.HasOne("EspacoViviTantra.Domain.Models.Bairro", "Bairro")
                        .WithMany()
                        .HasForeignKey("BairroId");

                    b.HasOne("EspacoViviTantra.Domain.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");

                    b.HasOne("EspacoViviTantra.Domain.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId");

                    b.HasOne("EspacoViviTantra.Domain.Models.TipoEndereco", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Pessoa", b =>
                {
                    b.HasOne("EspacoViviTantra.Domain.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("EspacoViviTantra.Domain.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Post", b =>
                {
                    b.HasOne("EspacoViviTantra.Domain.Models.Imagem", "Imagem")
                        .WithMany()
                        .HasForeignKey("ImagemId");

                    b.HasOne("EspacoViviTantra.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");

                    b.HasOne("EspacoViviTantra.Domain.Models.TipoPost", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Telefone", b =>
                {
                    b.HasOne("EspacoViviTantra.Domain.Models.TipoTelefone", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId");
                });

            modelBuilder.Entity("EspacoViviTantra.Domain.Models.Usuario", b =>
                {
                    b.HasOne("EspacoViviTantra.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");

                    b.HasOne("EspacoViviTantra.Domain.Models.UsuarioStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("EspacoViviTantra.Domain.Models.TipoUsuario", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId");
                });
#pragma warning restore 612, 618
        }
    }
}
