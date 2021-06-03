﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project02_EF_MVC.Data;

namespace Project02_EF_MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210603154326_seeding_StudentsCourses")]
    partial class seeding_StudentsCourses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Project02_EF_MVC.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1010,
                            Title = "ASP.NET"
                        },
                        new
                        {
                            Id = 1020,
                            Title = "React"
                        },
                        new
                        {
                            Id = 1030,
                            Title = "Unit Testing"
                        },
                        new
                        {
                            Id = 1040,
                            Title = "Design Pattern"
                        });
                });

            modelBuilder.Entity("Project02_EF_MVC.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Turki",
                            LastName = "Alqurashi"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Ahmed",
                            LastName = "Alzubadi"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Adel",
                            LastName = "Kalu"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Abdullah",
                            LastName = "Al haif"
                        });
                });

            modelBuilder.Entity("Project02_EF_MVC.Models.StudentsCourses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentsCourses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1010,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1020,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1030,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 1040,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 1010,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 1020,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 1030,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 1040,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 1010,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 1020,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 1030,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 12,
                            CourseId = 1040,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 13,
                            CourseId = 1010,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 14,
                            CourseId = 1020,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 15,
                            CourseId = 1030,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 16,
                            CourseId = 1040,
                            StudentId = 4
                        });
                });

            modelBuilder.Entity("Project02_EF_MVC.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1010,
                            FirstName = "Sami",
                            LastName = "Aldahlawi"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1010,
                            FirstName = "Ghada",
                            LastName = "Almutairi"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1010,
                            FirstName = "Hatem",
                            LastName = "Alsalman"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 1020,
                            FirstName = "Abdullah",
                            LastName = "Altwaim"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 1020,
                            FirstName = "Noora ",
                            LastName = "Abdullah"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 1040,
                            FirstName = "Norah",
                            LastName = "Mohsen"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 1040,
                            FirstName = "Sarah",
                            LastName = "Alqahtani"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 1030,
                            FirstName = "Fai",
                            LastName = "Alotaibi"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 1030,
                            FirstName = "Nouf",
                            LastName = "Alhassan"
                        });
                });

            modelBuilder.Entity("Project02_EF_MVC.Models.StudentsCourses", b =>
                {
                    b.HasOne("Project02_EF_MVC.Models.Course", "Course")
                        .WithMany("StudentsCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project02_EF_MVC.Models.Student", "Student")
                        .WithMany("StudentsCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project02_EF_MVC.Models.Teacher", b =>
                {
                    b.HasOne("Project02_EF_MVC.Models.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
