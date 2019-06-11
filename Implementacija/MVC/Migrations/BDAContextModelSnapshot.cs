﻿// <auto-generated />
using System;
using BloodDonationApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloodDonationApplication.Migrations
{
    [DbContext(typeof(BDAContext))]
    partial class BDAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BloodDonationApplication.Models.Donacija", b =>
                {
                    b.Property<int>("DonacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumDonacije");

                    b.Property<double>("DoniranaKolicinaKrvi");

                    b.Property<int?>("DoniraneKolicineKomponenteKrviId");

                    b.Property<int?>("DonorId");

                    b.Property<int?>("ZavodId");

                    b.HasKey("DonacijaId");

                    b.HasIndex("DoniraneKolicineKomponenteKrviId");

                    b.HasIndex("DonorId");

                    b.HasIndex("ZavodId");

                    b.ToTable("Donacija");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Donor", b =>
                {
                    b.Property<int>("DonorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojMobilnogTelefona");

                    b.Property<string>("Email");

                    b.Property<string>("Grad");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<int?>("KrvnaGrupaId");

                    b.Property<string>("Prezime");

                    b.Property<int?>("ZavodId");

                    b.HasKey("DonorId");

                    b.HasIndex("KrvnaGrupaId");

                    b.HasIndex("ZavodId");

                    b.ToTable("Donor");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Klinika", b =>
                {
                    b.Property<int>("KlinikaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("KlinikaId");

                    b.ToTable("Klinika");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.KomponenteKrvi", b =>
                {
                    b.Property<int>("KomponenteKrviId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Eritrociti");

                    b.Property<double>("KrvnaPlazma");

                    b.Property<double>("Leukociti");

                    b.Property<double>("Trombociti");

                    b.HasKey("KomponenteKrviId");

                    b.ToTable("KomponenteKrvi");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("sifra");

                    b.HasKey("KorisnikId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.KrvnaGrupa", b =>
                {
                    b.Property<int>("KrvnaGrupaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("KrvnaGrupaId");

                    b.ToTable("KrvnaGrupa");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.LaboratorijskiNalaz", b =>
                {
                    b.Property<int>("LaboratorijskiNalazId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Glukoza");

                    b.Property<double>("Hemoglobin");

                    b.Property<double>("Holesterol");

                    b.Property<int?>("KomponenteKrviId");

                    b.Property<double>("Trigliceridi");

                    b.Property<double>("Zeljezo");

                    b.HasKey("LaboratorijskiNalazId");

                    b.HasIndex("KomponenteKrviId");

                    b.ToTable("LaboratorijskiNalaz");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Pregled", b =>
                {
                    b.Property<int>("PregledId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPregleda");

                    b.Property<string>("DetaljiPregleda");

                    b.Property<int?>("DonorId");

                    b.Property<int?>("LabNalazIdLaboratorijskiNalazId");

                    b.Property<bool>("UspjesanPregled");

                    b.HasKey("PregledId");

                    b.HasIndex("DonorId");

                    b.HasIndex("LabNalazIdLaboratorijskiNalazId");

                    b.ToTable("Pregled");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Zahtjev", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KlinikaId");

                    b.Property<double>("KolicinaKrvi");

                    b.Property<int?>("KolicineKopmonentiKomponenteKrviId");

                    b.Property<int?>("KrvnaGrupaId");

                    b.Property<bool>("Odobren");

                    b.Property<int?>("ZavodId");

                    b.HasKey("ZahtjevId");

                    b.HasIndex("KlinikaId");

                    b.HasIndex("KolicineKopmonentiKomponenteKrviId");

                    b.HasIndex("KrvnaGrupaId");

                    b.HasIndex("ZavodId");

                    b.ToTable("Zahtjev");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Zalihe", b =>
                {
                    b.Property<int>("ZaliheId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Eritrociti");

                    b.Property<double>("Krv");

                    b.Property<int?>("KrvnaGrupaId");

                    b.Property<double>("KrvnaPlazma");

                    b.Property<double>("Leukociti");

                    b.Property<double>("Trombociti");

                    b.Property<int?>("ZavodId");

                    b.HasKey("ZaliheId");

                    b.HasIndex("KrvnaGrupaId");

                    b.HasIndex("ZavodId");

                    b.ToTable("Zalihe");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Zavod", b =>
                {
                    b.Property<int>("ZavodId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Grad");

                    b.Property<string>("Naziv");

                    b.HasKey("ZavodId");

                    b.ToTable("Zavod");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Donacija", b =>
                {
                    b.HasOne("BloodDonationApplication.Models.KomponenteKrvi", "DoniraneKolicine")
                        .WithMany()
                        .HasForeignKey("DoniraneKolicineKomponenteKrviId");

                    b.HasOne("BloodDonationApplication.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId");

                    b.HasOne("BloodDonationApplication.Models.Zavod")
                        .WithMany("ListaDonacija")
                        .HasForeignKey("ZavodId");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Donor", b =>
                {
                    b.HasOne("BloodDonationApplication.Models.KrvnaGrupa", "KrvnaGrupa")
                        .WithMany()
                        .HasForeignKey("KrvnaGrupaId");

                    b.HasOne("BloodDonationApplication.Models.Zavod")
                        .WithMany("ListaDonora")
                        .HasForeignKey("ZavodId");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.LaboratorijskiNalaz", b =>
                {
                    b.HasOne("BloodDonationApplication.Models.KomponenteKrvi", "KomponenteKrvi")
                        .WithMany()
                        .HasForeignKey("KomponenteKrviId");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Pregled", b =>
                {
                    b.HasOne("BloodDonationApplication.Models.Donor")
                        .WithMany("Pregledi")
                        .HasForeignKey("DonorId");

                    b.HasOne("BloodDonationApplication.Models.LaboratorijskiNalaz", "LabNalazId")
                        .WithMany()
                        .HasForeignKey("LabNalazIdLaboratorijskiNalazId");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Zahtjev", b =>
                {
                    b.HasOne("BloodDonationApplication.Models.Klinika")
                        .WithMany("Zahtjevi")
                        .HasForeignKey("KlinikaId");

                    b.HasOne("BloodDonationApplication.Models.KomponenteKrvi", "KolicineKopmonenti")
                        .WithMany()
                        .HasForeignKey("KolicineKopmonentiKomponenteKrviId");

                    b.HasOne("BloodDonationApplication.Models.KrvnaGrupa", "KrvnaGrupa")
                        .WithMany()
                        .HasForeignKey("KrvnaGrupaId");

                    b.HasOne("BloodDonationApplication.Models.Zavod")
                        .WithMany("ListaZahtjeva")
                        .HasForeignKey("ZavodId");
                });

            modelBuilder.Entity("BloodDonationApplication.Models.Zalihe", b =>
                {
                    b.HasOne("BloodDonationApplication.Models.KrvnaGrupa", "KrvnaGrupa")
                        .WithMany()
                        .HasForeignKey("KrvnaGrupaId");

                    b.HasOne("BloodDonationApplication.Models.Zavod")
                        .WithMany("ZaliheKomponente")
                        .HasForeignKey("ZavodId");
                });
#pragma warning restore 612, 618
        }
    }
}
