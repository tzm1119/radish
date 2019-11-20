﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rbmk.Radish.Services.Persistence;

namespace Rbmk.Radish.Services.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190709171421_Add_Connection")]
    partial class Add_Connection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("Rbmk.Radish.Services.Persistence.Entities.ConnectionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConnectionString")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.ToTable("connections");
                });
#pragma warning restore 612, 618
        }
    }
}
