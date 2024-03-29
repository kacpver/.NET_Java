﻿// <auto-generated />
using APIkonsolowa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIkonsolowa.Migrations
{
    [DbContext(typeof(Currencies))]
    partial class CurrenciesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("APIkonsolowa.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("base")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("timestamp")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("data");
                });

            modelBuilder.Entity("APIkonsolowa.Rates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CZK")
                        .HasColumnType("REAL");

                    b.Property<double>("EUR")
                        .HasColumnType("REAL");

                    b.Property<double>("GBP")
                        .HasColumnType("REAL");

                    b.Property<double>("PLN")
                        .HasColumnType("REAL");

                    b.Property<int>("dataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("dataId")
                        .IsUnique();

                    b.ToTable("rates");
                });

            modelBuilder.Entity("APIkonsolowa.Rates", b =>
                {
                    b.HasOne("APIkonsolowa.Data", "data")
                        .WithOne("rates")
                        .HasForeignKey("APIkonsolowa.Rates", "dataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("data");
                });

            modelBuilder.Entity("APIkonsolowa.Data", b =>
                {
                    b.Navigation("rates")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
