﻿// <auto-generated />
using System;
using BolaoShow.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BolaoShow.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200123200100_link_user_to_aostas")]
    partial class link_user_to_aostas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Aposta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConcursoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Dezena_01")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_02")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_03")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_04")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_05")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ValorAposta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ConcursoId");

                    b.ToTable("Apostas");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Concurso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataFimConcurso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicioConcurso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("NumeroConcurso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Concurso");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Sorteio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConcursoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dezena_01")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_02")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_03")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_04")
                        .HasColumnType("int");

                    b.Property<int>("Dezena_05")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConcursoId");

                    b.ToTable("Sorteios");
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
