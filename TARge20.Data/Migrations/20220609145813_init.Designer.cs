﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20220609145813_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.Ametinimetus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kvalifikatsioonid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tööülesanded")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Ametinimetus");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Haiguslehed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Algus")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Lõpp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Põhjus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Haiguslehed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Harukontor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktisik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lühinimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PeakontorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RegistriNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoniNr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PeakontorId");

                    b.ToTable("Harukontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Algus")
                        .HasColumnType("datetime2");

                    b.Property<string>("EsemeKood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EsemeNimetus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lõpp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Laenutus");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Lapsed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Eesnimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perekonnanimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Lapsed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ligipääsuload", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HarukontorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kasutajatunnus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ViimaneKülastus")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HarukontorId");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Ligipääsuload");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Palved", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ettepanek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Kuupäev")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PeakontorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Põhjus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sisu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PeakontorId");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Palved");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Peakontor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaNimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KontaktTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktisik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LühiNimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistriNr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peakontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkused", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Algus")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lõpp")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Puhkused");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tervisekontroll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Asutus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KontrolliAeg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tulemus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Tervisekontroll");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Töötaja", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eesnimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HarukontorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Isikukood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kandevõime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perekonnanimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TöölAlates")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TöölKuni")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HarukontorId");

                    b.ToTable("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vihjed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Kuupäev")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PeakontorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Põhjus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sisu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PeakontorId");

                    b.ToTable("Vihjed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ametinimetus", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Ametinimetus")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Haiguslehed", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Haiguslehed")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Harukontor", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Peakontor", "Peakontor")
                        .WithMany("Harukontor")
                        .HasForeignKey("PeakontorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Peakontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutus", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Laenutus")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Lapsed", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Lapsed")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ligipääsuload", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Harukontor", "Harukontor")
                        .WithMany("Ligipääsuload")
                        .HasForeignKey("HarukontorId");

                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Ligipääsuload")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Harukontor");

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Palved", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Peakontor", "Peakontor")
                        .WithMany("Palved")
                        .HasForeignKey("PeakontorId");

                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Palved")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Peakontor");

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkused", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Puhkused")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tervisekontroll", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Töötaja", "Töötaja")
                        .WithMany("Tervisekontroll")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Töötaja", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Harukontor", "Harukontor")
                        .WithMany("Töötaja")
                        .HasForeignKey("HarukontorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Harukontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vihjed", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Peakontor", "Peakontor")
                        .WithMany("Vihjed")
                        .HasForeignKey("PeakontorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Peakontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Harukontor", b =>
                {
                    b.Navigation("Ligipääsuload");

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Peakontor", b =>
                {
                    b.Navigation("Harukontor");

                    b.Navigation("Palved");

                    b.Navigation("Vihjed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Töötaja", b =>
                {
                    b.Navigation("Ametinimetus");

                    b.Navigation("Haiguslehed");

                    b.Navigation("Laenutus");

                    b.Navigation("Lapsed");

                    b.Navigation("Ligipääsuload");

                    b.Navigation("Palved");

                    b.Navigation("Puhkused");

                    b.Navigation("Tervisekontroll");
                });
#pragma warning restore 612, 618
        }
    }
}
