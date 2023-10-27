﻿// <auto-generated />
using System;
using Library_project.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library_project.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20231027074909_firstMigration")]
    partial class firstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Library_project.Models.Adres", b =>
                {
                    b.Property<Guid>("IDAdres")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDUlica")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NumerBudynku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumerMieszkania")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UlicaIDUlica")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDAdres");

                    b.HasIndex("UlicaIDUlica");

                    b.ToTable("Adresy");
                });

            modelBuilder.Entity("Library_project.Models.Bibliotekarz", b =>
                {
                    b.Property<Guid>("IDBibliotekarz")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DanaLogowaniaIDDanaLogowania")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DanaOsobowaIDDanaOsobowa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDDanaLogowania")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDDanaOsobowe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Pensja")
                        .HasColumnType("int");

                    b.HasKey("IDBibliotekarz");

                    b.HasIndex("DanaLogowaniaIDDanaLogowania");

                    b.HasIndex("DanaOsobowaIDDanaOsobowa");

                    b.ToTable("Bibliotekarze");
                });

            modelBuilder.Entity("Library_project.Models.Czytelnik", b =>
                {
                    b.Property<Guid>("IDCzytelnik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DanaLogowaniaIDDanaLogowania")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DanaOsobowaIDDanaOsobowa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDDanaLogowania")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDDanaOsobowe")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDCzytelnik");

                    b.HasIndex("DanaLogowaniaIDDanaLogowania");

                    b.HasIndex("DanaOsobowaIDDanaOsobowa");

                    b.ToTable("Czytelnicy");
                });

            modelBuilder.Entity("Library_project.Models.DanaLogowania", b =>
                {
                    b.Property<Guid>("IDDanaLogowania")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDDanaLogowania");

                    b.ToTable("DaneLogowania");
                });

            modelBuilder.Entity("Library_project.Models.DanaOsobowa", b =>
                {
                    b.Property<Guid>("IDDanaOsobowa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdresaIDAdres")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDAdres")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDOsoba")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OsobaIDOsoba")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("IDDanaOsobowa");

                    b.HasIndex("AdresaIDAdres");

                    b.HasIndex("OsobaIDOsoba");

                    b.ToTable("DaneOsobowe");
                });

            modelBuilder.Entity("Library_project.Models.Egzemplarz", b =>
                {
                    b.Property<Guid>("IDEgzemplarz")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Dostepnosc")
                        .HasColumnType("bit");

                    b.Property<Guid>("IDKsiazka")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KsiazkaISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RokZakupu")
                        .HasColumnType("int");

                    b.HasKey("IDEgzemplarz");

                    b.HasIndex("KsiazkaISBN");

                    b.ToTable("Egzemplarze");
                });

            modelBuilder.Entity("Library_project.Models.Gatunek", b =>
                {
                    b.Property<Guid?>("IDGatunek")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDGatunek");

                    b.ToTable("Gatunki");
                });

            modelBuilder.Entity("Library_project.Models.Ksiazka", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("GatunekIDGatunek")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDGatunek")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDWydawnictwo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LiczbaStrong")
                        .HasColumnType("int");

                    b.Property<int>("RokWydania")
                        .HasColumnType("int");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WydawnictwoIDWydawnictwo")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ISBN");

                    b.HasIndex("GatunekIDGatunek");

                    b.HasIndex("WydawnictwoIDWydawnictwo");

                    b.ToTable("Ksiazki");
                });

            modelBuilder.Entity("Library_project.Models.KsiazkaAutor", b =>
                {
                    b.Property<Guid>("IDKsiazkaAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKsiazka")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDOsoba")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KsiazkaISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("OsobaIDOsoba")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDKsiazkaAutor");

                    b.HasIndex("KsiazkaISBN");

                    b.HasIndex("OsobaIDOsoba");

                    b.ToTable("KsiazkaAutorzy");
                });

            modelBuilder.Entity("Library_project.Models.Miasto", b =>
                {
                    b.Property<Guid>("IDMiasto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDWojewodztwo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WojewodztwoIDWojewodztwo")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDMiasto");

                    b.HasIndex("WojewodztwoIDWojewodztwo");

                    b.ToTable("Miasta");
                });

            modelBuilder.Entity("Library_project.Models.Osoba", b =>
                {
                    b.Property<Guid?>("IDOsoba")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataUrodzenia")
                        .HasColumnType("Date");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDOsoba");

                    b.ToTable("Osoby");
                });

            modelBuilder.Entity("Library_project.Models.Ulica", b =>
                {
                    b.Property<Guid>("IDUlica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDMiasto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KodPocztowy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MiastoIDMiasto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDUlica");

                    b.HasIndex("MiastoIDMiasto");

                    b.ToTable("Ulice");
                });

            modelBuilder.Entity("Library_project.Models.Wojewodztwo", b =>
                {
                    b.Property<Guid>("IDWojewodztwo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDWojewodztwo");

                    b.ToTable("Wojewodztwa");
                });

            modelBuilder.Entity("Library_project.Models.Wydawnictwo", b =>
                {
                    b.Property<Guid>("IDWydawnictwo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDWydawnictwo");

                    b.ToTable("Wydawnictwa");
                });

            modelBuilder.Entity("Library_project.Models.Wypozyczenie", b =>
                {
                    b.Property<Guid?>("IDWypozyczenie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BibliotekarzIDBibliotekarz")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CzytelnikIDCzytelnik")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataOddania")
                        .HasColumnType("Date");

                    b.Property<Guid?>("IDBibliotekarza")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDCzytelnika")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDWypozyczenie");

                    b.HasIndex("BibliotekarzIDBibliotekarz");

                    b.HasIndex("CzytelnikIDCzytelnik");

                    b.ToTable("Wypozyczenia");
                });

            modelBuilder.Entity("Library_project.Models.WypozyczenieEgzemplarz", b =>
                {
                    b.Property<Guid>("IDWypozyczenieEgzemplarz")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataOddania")
                        .HasColumnType("Date");

                    b.Property<Guid?>("EgzemplarzIDEgzemplarz")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDEgzemplarz")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDWypozyczenia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WypozyczenieIDWypozyczenie")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDWypozyczenieEgzemplarz");

                    b.HasIndex("EgzemplarzIDEgzemplarz");

                    b.HasIndex("WypozyczenieIDWypozyczenie");

                    b.ToTable("WypozyczenieEgzemplarze");
                });

            modelBuilder.Entity("Library_project.Models.Adres", b =>
                {
                    b.HasOne("Library_project.Models.Ulica", "Ulica")
                        .WithMany()
                        .HasForeignKey("UlicaIDUlica");

                    b.Navigation("Ulica");
                });

            modelBuilder.Entity("Library_project.Models.Bibliotekarz", b =>
                {
                    b.HasOne("Library_project.Models.DanaLogowania", "DanaLogowania")
                        .WithMany("Bibliotekarz")
                        .HasForeignKey("DanaLogowaniaIDDanaLogowania");

                    b.HasOne("Library_project.Models.DanaOsobowa", "DanaOsobowa")
                        .WithMany("Bibliotekarz")
                        .HasForeignKey("DanaOsobowaIDDanaOsobowa");

                    b.Navigation("DanaLogowania");

                    b.Navigation("DanaOsobowa");
                });

            modelBuilder.Entity("Library_project.Models.Czytelnik", b =>
                {
                    b.HasOne("Library_project.Models.DanaLogowania", "DanaLogowania")
                        .WithMany("Czytelnik")
                        .HasForeignKey("DanaLogowaniaIDDanaLogowania");

                    b.HasOne("Library_project.Models.DanaOsobowa", "DanaOsobowa")
                        .WithMany("Czytelnik")
                        .HasForeignKey("DanaOsobowaIDDanaOsobowa");

                    b.Navigation("DanaLogowania");

                    b.Navigation("DanaOsobowa");
                });

            modelBuilder.Entity("Library_project.Models.DanaOsobowa", b =>
                {
                    b.HasOne("Library_project.Models.Adres", "Adresa")
                        .WithMany("DanaOsobowe")
                        .HasForeignKey("AdresaIDAdres");

                    b.HasOne("Library_project.Models.Osoba", "Osoba")
                        .WithMany("DaneOsobowa")
                        .HasForeignKey("OsobaIDOsoba");

                    b.Navigation("Adresa");

                    b.Navigation("Osoba");
                });

            modelBuilder.Entity("Library_project.Models.Egzemplarz", b =>
                {
                    b.HasOne("Library_project.Models.Ksiazka", "Ksiazka")
                        .WithMany("Egzemplarz")
                        .HasForeignKey("KsiazkaISBN");

                    b.Navigation("Ksiazka");
                });

            modelBuilder.Entity("Library_project.Models.Ksiazka", b =>
                {
                    b.HasOne("Library_project.Models.Gatunek", "Gatunek")
                        .WithMany("Ksiazki")
                        .HasForeignKey("GatunekIDGatunek")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_project.Models.Wydawnictwo", "Wydawnictwo")
                        .WithMany("Ksiazki")
                        .HasForeignKey("WydawnictwoIDWydawnictwo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gatunek");

                    b.Navigation("Wydawnictwo");
                });

            modelBuilder.Entity("Library_project.Models.KsiazkaAutor", b =>
                {
                    b.HasOne("Library_project.Models.Ksiazka", "Ksiazka")
                        .WithMany("KsiazkaAutorzy")
                        .HasForeignKey("KsiazkaISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_project.Models.Osoba", "Osoba")
                        .WithMany("KsiazkaAutorzy")
                        .HasForeignKey("OsobaIDOsoba")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ksiazka");

                    b.Navigation("Osoba");
                });

            modelBuilder.Entity("Library_project.Models.Miasto", b =>
                {
                    b.HasOne("Library_project.Models.Wojewodztwo", "Wojewodztwo")
                        .WithMany("Miasta")
                        .HasForeignKey("WojewodztwoIDWojewodztwo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wojewodztwo");
                });

            modelBuilder.Entity("Library_project.Models.Ulica", b =>
                {
                    b.HasOne("Library_project.Models.Miasto", "Miasto")
                        .WithMany("Ulica")
                        .HasForeignKey("MiastoIDMiasto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miasto");
                });

            modelBuilder.Entity("Library_project.Models.Wypozyczenie", b =>
                {
                    b.HasOne("Library_project.Models.Bibliotekarz", "Bibliotekarz")
                        .WithMany()
                        .HasForeignKey("BibliotekarzIDBibliotekarz");

                    b.HasOne("Library_project.Models.Czytelnik", "Czytelnik")
                        .WithMany()
                        .HasForeignKey("CzytelnikIDCzytelnik");

                    b.Navigation("Bibliotekarz");

                    b.Navigation("Czytelnik");
                });

            modelBuilder.Entity("Library_project.Models.WypozyczenieEgzemplarz", b =>
                {
                    b.HasOne("Library_project.Models.Egzemplarz", "Egzemplarz")
                        .WithMany("WypozyczenieEgzemplarz")
                        .HasForeignKey("EgzemplarzIDEgzemplarz");

                    b.HasOne("Library_project.Models.Wypozyczenie", "Wypozyczenie")
                        .WithMany("WypozyczenieEgzemplarz")
                        .HasForeignKey("WypozyczenieIDWypozyczenie");

                    b.Navigation("Egzemplarz");

                    b.Navigation("Wypozyczenie");
                });

            modelBuilder.Entity("Library_project.Models.Adres", b =>
                {
                    b.Navigation("DanaOsobowe");
                });

            modelBuilder.Entity("Library_project.Models.DanaLogowania", b =>
                {
                    b.Navigation("Bibliotekarz");

                    b.Navigation("Czytelnik");
                });

            modelBuilder.Entity("Library_project.Models.DanaOsobowa", b =>
                {
                    b.Navigation("Bibliotekarz");

                    b.Navigation("Czytelnik");
                });

            modelBuilder.Entity("Library_project.Models.Egzemplarz", b =>
                {
                    b.Navigation("WypozyczenieEgzemplarz");
                });

            modelBuilder.Entity("Library_project.Models.Gatunek", b =>
                {
                    b.Navigation("Ksiazki");
                });

            modelBuilder.Entity("Library_project.Models.Ksiazka", b =>
                {
                    b.Navigation("Egzemplarz");

                    b.Navigation("KsiazkaAutorzy");
                });

            modelBuilder.Entity("Library_project.Models.Miasto", b =>
                {
                    b.Navigation("Ulica");
                });

            modelBuilder.Entity("Library_project.Models.Osoba", b =>
                {
                    b.Navigation("DaneOsobowa");

                    b.Navigation("KsiazkaAutorzy");
                });

            modelBuilder.Entity("Library_project.Models.Wojewodztwo", b =>
                {
                    b.Navigation("Miasta");
                });

            modelBuilder.Entity("Library_project.Models.Wydawnictwo", b =>
                {
                    b.Navigation("Ksiazki");
                });

            modelBuilder.Entity("Library_project.Models.Wypozyczenie", b =>
                {
                    b.Navigation("WypozyczenieEgzemplarz");
                });
#pragma warning restore 612, 618
        }
    }
}
