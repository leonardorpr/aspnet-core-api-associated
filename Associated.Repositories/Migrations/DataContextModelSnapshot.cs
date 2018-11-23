﻿// <auto-generated />
using Associated.Repositories.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Associated.Repositories.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Associated.Domain.Associate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Cep");

                    b.Property<string>("City");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<int?>("MaritalStatusId");

                    b.Property<string>("Name");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.HasIndex("MaritalStatusId");

                    b.ToTable("Associated");
                });

            modelBuilder.Entity("Associated.Domain.Dependent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssociateId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int?>("KinshipId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AssociateId");

                    b.HasIndex("KinshipId");

                    b.ToTable("Dependents");
                });

            modelBuilder.Entity("Associated.Domain.Kinship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Kinships");
                });

            modelBuilder.Entity("Associated.Domain.MaritalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("MaritalStatus");
                });

            modelBuilder.Entity("Associated.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Associated.Domain.Associate", b =>
                {
                    b.HasOne("Associated.Domain.MaritalStatus", "MaritalStatus")
                        .WithMany("Associate")
                        .HasForeignKey("MaritalStatusId");
                });

            modelBuilder.Entity("Associated.Domain.Dependent", b =>
                {
                    b.HasOne("Associated.Domain.Associate")
                        .WithMany("Dependents")
                        .HasForeignKey("AssociateId");

                    b.HasOne("Associated.Domain.Kinship", "Kinship")
                        .WithMany("Dependent")
                        .HasForeignKey("KinshipId");
                });
#pragma warning restore 612, 618
        }
    }
}
