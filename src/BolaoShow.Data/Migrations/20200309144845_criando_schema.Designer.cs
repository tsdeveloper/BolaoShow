﻿// <auto-generated />
using System;
using BolaoShow.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BolaoShow.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200309144845_criando_schema")]
    partial class criando_schema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Aposta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ConcursoId")
                        .HasColumnType("uuid");

                    b.Property<int>("Dezena_01")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_02")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_03")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_04")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_05")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ValorAposta")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ConcursoId");

                    b.ToTable("Apostas","bolao");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Concurso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DataFimConcurso")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataInicioConcurso")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("NumeroConcurso")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Concurso");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Sorteio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ConcursoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Dezena_01")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_02")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_03")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_04")
                        .HasColumnType("integer");

                    b.Property<int>("Dezena_05")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ConcursoId");

                    b.ToTable("Sorteios","bolao");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Aposta", b =>
                {
                    b.HasOne("BolaoShow.Bussiness.Models.Concurso", "Concurso")
                        .WithMany()
                        .HasForeignKey("ConcursoId")
                        .IsRequired();
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Sorteio", b =>
                {
                    b.HasOne("BolaoShow.Bussiness.Models.Concurso", "Concurso")
                        .WithMany()
                        .HasForeignKey("ConcursoId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}