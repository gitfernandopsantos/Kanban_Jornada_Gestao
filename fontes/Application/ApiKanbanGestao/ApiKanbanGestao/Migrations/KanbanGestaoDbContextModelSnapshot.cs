﻿// <auto-generated />
using System;
using ApiKanbanGestao.DataDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiKanbanGestao.Migrations
{
    [DbContext(typeof(KanbanGestaoDbContext))]
    partial class KanbanGestaoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiKanbanGestao.Entity.Atividade", b =>
                {
                    b.Property<int>("IdAtividade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdAtividade"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("IdAtividade");

                    b.ToTable("Atividade", "public");
                });

            modelBuilder.Entity("ApiKanbanGestao.Entity.Coluna", b =>
                {
                    b.Property<int>("IdColuna")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdColuna"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("IdColuna");

                    b.ToTable("Coluna", "public");
                });

            modelBuilder.Entity("ApiKanbanGestao.Entity.ColunaXAtividade", b =>
                {
                    b.Property<int>("IdColunaXAtividade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdColunaXAtividade"));

                    b.Property<int>("AtividadeId")
                        .HasColumnType("integer");

                    b.Property<int>("ColunaId")
                        .HasColumnType("integer");

                    b.HasKey("IdColunaXAtividade");

                    b.HasIndex("AtividadeId");

                    b.HasIndex("ColunaId");

                    b.ToTable("ColunaXAtividade", "public");
                });

            modelBuilder.Entity("ApiKanbanGestao.Entity.ColunaXAtividade", b =>
                {
                    b.HasOne("ApiKanbanGestao.Entity.Atividade", "Atividade")
                        .WithMany()
                        .HasForeignKey("AtividadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiKanbanGestao.Entity.Coluna", "Coluna")
                        .WithMany()
                        .HasForeignKey("ColunaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atividade");

                    b.Navigation("Coluna");
                });
#pragma warning restore 612, 618
        }
    }
}
