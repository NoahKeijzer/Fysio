﻿// <auto-generated />
using System;
using Fysio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fysio.Migrations
{
    [DbContext(typeof(FysioDbContext))]
    [Migration("20210925095006_AddDocenten")]
    partial class AddDocenten
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fysio.Models.Patiëntdossier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Behandelingen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Behandelplan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumAanmelding")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumOntslag")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiagnosOmschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiagnoseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FysiotherapeutEmailadres")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HoofdbehandelaarEmailadres")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IntakeGedaanDoor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntakeOnderSupervisieVan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Klachten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opmerkingen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientEmailadres")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentEmailadres")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FysiotherapeutEmailadres");

                    b.HasIndex("HoofdbehandelaarEmailadres");

                    b.HasIndex("PatientEmailadres");

                    b.HasIndex("StudentEmailadres");

                    b.ToTable("Patiëntdossiers");
                });

            modelBuilder.Entity("Fysio.Models.Person", b =>
                {
                    b.Property<string>("Emailadres")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Geslacht")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefoonnummer")
                        .HasColumnType("int");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emailadres");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Fysio.Models.Docent", b =>
                {
                    b.HasBaseType("Fysio.Models.Person");

                    b.Property<int>("Personeelsnummer")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Docent");
                });

            modelBuilder.Entity("Fysio.Models.Fysiotherapeut", b =>
                {
                    b.HasBaseType("Fysio.Models.Person");

                    b.Property<int>("BIGNummer")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Fysiotherapeut");
                });

            modelBuilder.Entity("Fysio.Models.Patient", b =>
                {
                    b.HasBaseType("Fysio.Models.Person");

                    b.Property<int>("Patiëntnummer")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("Fysio.Models.Student", b =>
                {
                    b.HasBaseType("Fysio.Models.Person");

                    b.Property<int>("Studentnummer")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Fysio.Models.Patiëntdossier", b =>
                {
                    b.HasOne("Fysio.Models.Fysiotherapeut", "Fysiotherapeut")
                        .WithMany()
                        .HasForeignKey("FysiotherapeutEmailadres");

                    b.HasOne("Fysio.Models.Fysiotherapeut", "Hoofdbehandelaar")
                        .WithMany()
                        .HasForeignKey("HoofdbehandelaarEmailadres");

                    b.HasOne("Fysio.Models.Patient", "Patient")
                        .WithMany("Patiëntdossier")
                        .HasForeignKey("PatientEmailadres");

                    b.HasOne("Fysio.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentEmailadres");

                    b.Navigation("Fysiotherapeut");

                    b.Navigation("Hoofdbehandelaar");

                    b.Navigation("Patient");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Fysio.Models.Patient", b =>
                {
                    b.Navigation("Patiëntdossier");
                });
#pragma warning restore 612, 618
        }
    }
}