﻿// <auto-generated />
using AT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AT.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("AT.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Device");
                });

            modelBuilder.Entity("AT.Models.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Softwares");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Software");
                });

            modelBuilder.Entity("AT.Models.Сomputer", b =>
                {
                    b.HasBaseType("AT.Models.Device");

                    b.Property<int>("OperatingSystemId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("OperatingSystemId");

                    b.HasDiscriminator().HasValue("Сomputer");
                });

            modelBuilder.Entity("AT.Models.OS", b =>
                {
                    b.HasBaseType("AT.Models.Software");

                    b.Property<int>("PackageManagerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShellId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("PackageManagerId");

                    b.HasIndex("ShellId");

                    b.HasDiscriminator().HasValue("OS");
                });

            modelBuilder.Entity("AT.Models.PackageManager", b =>
                {
                    b.HasBaseType("AT.Models.Software");

                    b.HasDiscriminator().HasValue("PackageManager");
                });

            modelBuilder.Entity("AT.Models.Shell", b =>
                {
                    b.HasBaseType("AT.Models.Software");

                    b.HasDiscriminator().HasValue("Shell");
                });

            modelBuilder.Entity("AT.Models.Сomputer", b =>
                {
                    b.HasOne("AT.Models.OS", "OperatingSystem")
                        .WithMany()
                        .HasForeignKey("OperatingSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperatingSystem");
                });

            modelBuilder.Entity("AT.Models.OS", b =>
                {
                    b.HasOne("AT.Models.PackageManager", "PackageManager")
                        .WithMany()
                        .HasForeignKey("PackageManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AT.Models.Shell", "Shell")
                        .WithMany()
                        .HasForeignKey("ShellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PackageManager");

                    b.Navigation("Shell");
                });
#pragma warning restore 612, 618
        }
    }
}
