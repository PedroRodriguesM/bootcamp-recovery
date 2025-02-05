﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoMercadoMVC.Data;

namespace ProjetoMercadoMVC.Migrations
{
    [DbContext(typeof(ProjetoMercadoMVCContext))]
    [Migration("20210927184056_InitialContent")]
    partial class InitialContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoMercadoMVC.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PRODUTO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_VALIDADE_PRODUTO");

                    b.Property<string>("Nome")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("NM_PRODUTO");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("VLR_PRODUTO");

                    b.HasKey("Id");

                    b.ToTable("TB_PRODUTO");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("NM_USUARIO");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIO");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_VENDA")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO_VENDA");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("VLR_TOTAL_VENDA");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("TB_VENDA");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.VendaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_VENDA_ITEM")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("ID_PRODUTO");

                    b.Property<int>("IdVenda")
                        .HasColumnType("int")
                        .HasColumnName("ID_VENDA");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("QTD_VENDA");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.HasIndex("IdVenda");

                    b.ToTable("TB_VENDA_ITEM");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.Venda", b =>
                {
                    b.HasOne("ProjetoMercadoMVC.Models.Usuario", "Usuario")
                        .WithMany("Vendas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.VendaItem", b =>
                {
                    b.HasOne("ProjetoMercadoMVC.Models.Produto", "Produto")
                        .WithMany("VendasDoProduto")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProjetoMercadoMVC.Models.Venda", "Venda")
                        .WithMany("Itens")
                        .HasForeignKey("IdVenda")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.Produto", b =>
                {
                    b.Navigation("VendasDoProduto");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.Usuario", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("ProjetoMercadoMVC.Models.Venda", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
