﻿// <auto-generated />
using Group2.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Group2.Migrations
{
    [DbContext(typeof(hackertonDbContext))]
    [Migration("20200826201241_clemo")]
    partial class clemo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Group2.Models.Doc_Res", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("PASSWORD")
                        .IsRequired();

                    b.Property<string>("PHONE")
                        .IsRequired();

                    b.Property<string>("ROLE");

                    b.Property<string>("fULL_NAME")
                        .IsRequired();

                    b.Property<string>("serviceNo")
                        .IsRequired();

                    b.Property<string>("uSERNAME")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("doc_Res");
                });

            modelBuilder.Entity("Group2.Models.UserDetails", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<string>("DocId");

                    b.Property<string>("Institution");

                    b.Property<string>("IsDiagnosed");

                    b.Property<string>("Problem");

                    b.Property<string>("UswerId")
                        .IsRequired();

                    b.Property<string>("date")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("userDetails");
                });

            modelBuilder.Entity("Group2.Models.Users", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("GENDER")
                        .IsRequired();

                    b.Property<string>("LOCATION")
                        .IsRequired();

                    b.Property<string>("PHONE")
                        .IsRequired();

                    b.Property<string>("ROLE")
                        .IsRequired();

                    b.Property<string>("d_O_b")
                        .IsRequired();

                    b.Property<string>("fULL_NAME")
                        .IsRequired();

                    b.Property<string>("uSERNAME")
                        .IsRequired();

                    b.Property<string>("uniqueId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Group2.Models.categories", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("catname")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Group2.Models.roles", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Role")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("roles");
                });
#pragma warning restore 612, 618
        }
    }
}
