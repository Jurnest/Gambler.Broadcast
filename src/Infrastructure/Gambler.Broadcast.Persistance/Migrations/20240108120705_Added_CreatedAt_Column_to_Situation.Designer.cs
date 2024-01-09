﻿// <auto-generated />
using System;
using Gambler.Broadcast.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gambler.Broadcast.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240108120705_Added_CreatedAt_Column_to_Situation")]
    partial class Added_CreatedAt_Column_to_Situation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gambler.Broadcast.Domain.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameProducerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxMultiplier")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rtp")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SelfMaxEarning")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SelfMaxMultiplier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameProducerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Gambler.Broadcast.Domain.Entities.GameProducer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProducerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameProducers");
                });

            modelBuilder.Entity("Gambler.Broadcast.Domain.Entities.Situation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CashIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CashOut")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("StartMoney")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Situations");
                });

            modelBuilder.Entity("Gambler.Broadcast.Domain.Entities.Game", b =>
                {
                    b.HasOne("Gambler.Broadcast.Domain.Entities.GameProducer", "GameProducer")
                        .WithMany("Games")
                        .HasForeignKey("GameProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameProducer");
                });

            modelBuilder.Entity("Gambler.Broadcast.Domain.Entities.GameProducer", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
