﻿// <auto-generated />
using System;
using Academia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Academia_Volvo.Migrations
{
    [DbContext(typeof(AcademiaContext))]
    [Migration("20240204171718_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Academia.Models.MAlunos", b =>
                {
                    b.Property<int>("Id_aluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_aluno"));

                    b.Property<string>("CPF_aluno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Data_nascimento_aluno")
                        .HasColumnType("date");

                    b.Property<string>("Email_aluno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_aula")
                        .HasColumnType("int");

                    b.Property<int?>("Id_contrato")
                        .HasColumnType("int");

                    b.Property<int?>("Id_endereco")
                        .HasColumnType("int");

                    b.Property<string>("Nome_aluno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Telefone_aluno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_aluno");

                    b.HasIndex("Id_aula");

                    b.HasIndex("Id_contrato");

                    b.HasIndex("Id_endereco");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Academia.Models.MAulas", b =>
                {
                    b.Property<int>("Id_aula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_aula"));

                    b.Property<DateOnly>("Data_aula")
                        .HasColumnType("date");

                    b.Property<string>("Descricao_aula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_aluno")
                        .HasColumnType("int");

                    b.Property<int>("Id_funcionario")
                        .HasColumnType("int");

                    b.HasKey("Id_aula");

                    b.HasIndex("Id_aluno");

                    b.HasIndex("Id_funcionario");

                    b.ToTable("Aulas");
                });

            modelBuilder.Entity("Academia.Models.MContratos", b =>
                {
                    b.Property<int>("Id_contrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_contrato"));

                    b.Property<DateOnly>("Data_inicio_contrato")
                        .HasColumnType("date");

                    b.Property<DateOnly>("Data_pagamento")
                        .HasColumnType("date");

                    b.Property<int>("Id_aluno")
                        .HasColumnType("int");

                    b.Property<int>("Id_funcionario")
                        .HasColumnType("int");

                    b.Property<int>("Id_plano")
                        .HasColumnType("int");

                    b.Property<int>("Id_receita")
                        .HasColumnType("int");

                    b.HasKey("Id_contrato");

                    b.HasIndex("Id_aluno");

                    b.HasIndex("Id_funcionario");

                    b.HasIndex("Id_plano");

                    b.HasIndex("Id_receita");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("Academia.Models.MDespesas", b =>
                {
                    b.Property<int>("Id_despesa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_despesa"));

                    b.Property<DateOnly>("Data_despesa")
                        .HasColumnType("date");

                    b.Property<string>("Descricao_despesa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_funcionario")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor_despesa")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_despesa");

                    b.HasIndex("Id_funcionario");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("Academia.Models.MEnderecos", b =>
                {
                    b.Property<int>("Id_endereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_endereco"));

                    b.Property<string>("Bairro_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_aluno")
                        .HasColumnType("int");

                    b.Property<int?>("Id_funcionario")
                        .HasColumnType("int");

                    b.Property<string>("Numero_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_endereco");

                    b.HasIndex("Id_aluno");

                    b.HasIndex("Id_funcionario");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Academia.Models.MFuncionarios", b =>
                {
                    b.Property<int>("Id_funcionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_funcionario"));

                    b.Property<string>("CPF_funcionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cargo_Funcionario")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Data_nascimento_funcionario")
                        .HasColumnType("date");

                    b.Property<string>("Email_funcionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_aula")
                        .HasColumnType("int");

                    b.Property<int?>("Id_despesas")
                        .HasColumnType("int");

                    b.Property<int?>("Id_endereco")
                        .HasColumnType("int");

                    b.Property<string>("Nome_funcionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario_funcionario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Telefone_funcionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_funcionario");

                    b.HasIndex("Id_aula");

                    b.HasIndex("Id_despesas");

                    b.HasIndex("Id_endereco");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Academia.Models.MInventario", b =>
                {
                    b.Property<int>("Id_item_inventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_item_inventario"));

                    b.Property<string>("Descricao_item_inventario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade_item_inventario")
                        .HasColumnType("int");

                    b.HasKey("Id_item_inventario");

                    b.ToTable("Inventario");
                });

            modelBuilder.Entity("Academia.Models.MPlanos", b =>
                {
                    b.Property<int>("Id_plano")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_plano"));

                    b.Property<string>("Descricao_plano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dias_plano")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor_plano")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_plano");

                    b.ToTable("Planos");
                });

            modelBuilder.Entity("Academia.Models.MReceitas", b =>
                {
                    b.Property<int>("Id_receita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_receita"));

                    b.Property<DateOnly>("Data_receita")
                        .HasColumnType("date");

                    b.Property<string>("Descricao_receita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_aluno")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor_receita")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_receita");

                    b.HasIndex("Id_aluno");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("Academia.Models.MAlunos", b =>
                {
                    b.HasOne("Academia.Models.MAulas", null)
                        .WithMany()
                        .HasForeignKey("Id_aula")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Academia.Models.MContratos", null)
                        .WithMany()
                        .HasForeignKey("Id_contrato")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Academia.Models.MEnderecos", null)
                        .WithMany()
                        .HasForeignKey("Id_endereco")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Academia.Models.MAulas", b =>
                {
                    b.HasOne("Academia.Models.MAlunos", null)
                        .WithMany()
                        .HasForeignKey("Id_aluno")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Academia.Models.MFuncionarios", null)
                        .WithMany()
                        .HasForeignKey("Id_funcionario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Academia.Models.MContratos", b =>
                {
                    b.HasOne("Academia.Models.MAlunos", null)
                        .WithMany()
                        .HasForeignKey("Id_aluno")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Academia.Models.MFuncionarios", null)
                        .WithMany()
                        .HasForeignKey("Id_funcionario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Academia.Models.MPlanos", null)
                        .WithMany()
                        .HasForeignKey("Id_plano")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Academia.Models.MReceitas", null)
                        .WithMany()
                        .HasForeignKey("Id_receita")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Academia.Models.MDespesas", b =>
                {
                    b.HasOne("Academia.Models.MFuncionarios", null)
                        .WithMany()
                        .HasForeignKey("Id_funcionario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Academia.Models.MEnderecos", b =>
                {
                    b.HasOne("Academia.Models.MAlunos", null)
                        .WithMany()
                        .HasForeignKey("Id_aluno")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Academia.Models.MFuncionarios", null)
                        .WithMany()
                        .HasForeignKey("Id_funcionario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Academia.Models.MFuncionarios", b =>
                {
                    b.HasOne("Academia.Models.MAulas", null)
                        .WithMany()
                        .HasForeignKey("Id_aula")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Academia.Models.MDespesas", null)
                        .WithMany()
                        .HasForeignKey("Id_despesas")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Academia.Models.MEnderecos", null)
                        .WithMany()
                        .HasForeignKey("Id_endereco")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Academia.Models.MReceitas", b =>
                {
                    b.HasOne("Academia.Models.MAlunos", null)
                        .WithMany()
                        .HasForeignKey("Id_aluno")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
