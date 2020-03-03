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
    [Migration("20200117180417_cria_aposta_sorteio")]
    partial class cria_aposta_sorteio
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

                    b.Property<decimal>("ValorAposta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Apostas");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Aposta_Sorteio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApostaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SorteioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApostaId");

                    b.HasIndex("SorteioId");

                    b.ToTable("Aposta_Sorteios");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Sorteio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
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

                    b.Property<int>("NumeroConcurso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sorteios");
                });

            modelBuilder.Entity("BolaoShow.Bussiness.Models.Aposta_Sorteio", b =>
                {
                    b.HasOne("BolaoShow.Bussiness.Models.Aposta", "Aposta")
                        .WithMany("Sorteios")
                        .HasForeignKey("ApostaId")
                        .IsRequired();

                    b.HasOne("BolaoShow.Bussiness.Models.Sorteio", "Sorteio")
                        .WithMany("Apostas")
                        .HasForeignKey("SorteioId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}