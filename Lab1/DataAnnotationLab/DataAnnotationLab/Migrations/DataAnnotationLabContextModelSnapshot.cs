﻿// <auto-generated />
using System;
using DataAnnotationLab.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAnnotationLab.Migrations
{
    [DbContext(typeof(DataAnnotationLabContext))]
    partial class DataAnnotationLabContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAnnotationLab.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("DataAnnotationLab.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("Section")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Room", (string)null);
                });

            modelBuilder.Entity("DataAnnotationLab.Models.Client", b =>
                {
                    b.OwnsOne("DataAnnotationLab.Models.Client.Credit#DataAnnotationLab.Models.Credit", "Credit", b1 =>
                        {
                            b1.Property<int>("ClientId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("ExpiryDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("HolderName")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<bool>("IsValid")
                                .HasColumnType("bit");

                            b1.HasKey("ClientId");

                            b1.ToTable("Client", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.Navigation("Credit")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
