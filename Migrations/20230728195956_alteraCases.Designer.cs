﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apiBrigadeiro.Context;

#nullable disable

namespace apiBrigadeiro.Migrations
{
    [DbContext(typeof(apiBrigadeiroContext))]
    [Migration("20230728195956_alteraCases")]
    partial class alteraCases
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("apiBrigadeiro.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Endereço")
                        .HasColumnType("text")
                        .HasColumnName("endereço");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .HasColumnType("text")
                        .HasColumnName("senha");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("apiBrigadeiro.Model.Compras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer")
                        .HasColumnName("clienteid");

                    b.Property<string>("FormaPagamento")
                        .HasColumnType("text")
                        .HasColumnName("formapagamento");

                    b.Property<int>("Frete")
                        .HasColumnType("integer")
                        .HasColumnName("frete");

                    b.Property<string>("ListaDoces")
                        .HasColumnType("text")
                        .HasColumnName("listadoces");

                    b.Property<int>("ValorTotal")
                        .HasColumnType("integer")
                        .HasColumnName("valortotal");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("compras");
                });

            modelBuilder.Entity("apiBrigadeiro.Model.Doce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ComprasId")
                        .HasColumnType("integer")
                        .HasColumnName("comprasid");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<int>("Quantidades")
                        .HasColumnType("integer")
                        .HasColumnName("quantidades");

                    b.Property<string>("Sabores")
                        .HasColumnType("text")
                        .HasColumnName("sabores");

                    b.Property<int>("Valores")
                        .HasColumnType("integer")
                        .HasColumnName("valores");

                    b.HasKey("Id");

                    b.HasIndex("ComprasId");

                    b.ToTable("doces");
                });

            modelBuilder.Entity("apiBrigadeiro.Model.Compras", b =>
                {
                    b.HasOne("apiBrigadeiro.Model.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("apiBrigadeiro.Model.Doce", b =>
                {
                    b.HasOne("apiBrigadeiro.Model.Compras", null)
                        .WithMany("doces")
                        .HasForeignKey("ComprasId");
                });

            modelBuilder.Entity("apiBrigadeiro.Model.Compras", b =>
                {
                    b.Navigation("doces");
                });
#pragma warning restore 612, 618
        }
    }
}
