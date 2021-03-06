// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lesson23_01._04._21.Db;

namespace lesson23_01._04._21.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("lesson23_01._04._21.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2020, 5, 30, 13, 42, 51, 840, DateTimeKind.Local).AddTicks(1115),
                            Text = "Если ты устал, то присять"
                        },
                        new
                        {
                            Id = 2,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2020, 5, 30, 13, 42, 51, 841, DateTimeKind.Local).AddTicks(2069),
                            Text = "Если ты покушал, то делай свое дело"
                        },
                        new
                        {
                            Id = 3,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2020, 5, 30, 13, 42, 51, 841, DateTimeKind.Local).AddTicks(2136),
                            Text = "Если ты не хочешь работать, то не работай"
                        },
                        new
                        {
                            Id = 4,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2020, 5, 30, 13, 42, 51, 841, DateTimeKind.Local).AddTicks(2144),
                            Text = "Если ты хочешь пить, то открой кран и выпей"
                        },
                        new
                        {
                            Id = 5,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2020, 5, 30, 13, 42, 51, 841, DateTimeKind.Local).AddTicks(2149),
                            Text = "Если ты хочешь есть, то открой холодильник"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
