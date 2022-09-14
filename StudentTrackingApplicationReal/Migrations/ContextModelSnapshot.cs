﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentTrackingApplicationReal.Shared.Models;

#nullable disable

namespace StudentTrackingApplicationReal.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"), 1L, 1);

                    b.Property<DateTime>("AttendanceDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("AttendancePaymentState")
                        .HasColumnType("bit");

                    b.Property<int>("AttendancePrice")
                        .HasColumnType("int");

                    b.Property<bool>("AttendanceState")
                        .HasColumnType("bit");

                    b.Property<int>("StudentCourseId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId");

                    b.HasIndex("StudentCourseId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<DateTime>("CourseCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CourseCredits")
                        .HasColumnType("int");

                    b.Property<int>("CourseDays")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CourseNumbers")
                        .HasColumnType("int");

                    b.Property<DateTime>("CourseStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CourseTotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("TimeFirst2Digits")
                        .HasColumnType("int");

                    b.Property<int>("TimeLast2Digits")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"), 1L, 1);

                    b.Property<DateTime>("ManagerCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ManagerEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ManagerPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ManagerSurname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ManagerUserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ManagerId");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.SchoolUser", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserName");

                    b.ToTable("SchoolUsers");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<DateTime>("StudentCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentDebts")
                        .HasColumnType("int");

                    b.Property<string>("StudentEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentGeneralAverageMark")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StudentPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StudentSurname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("StudentTotalCourseCredits")
                        .HasColumnType("int");

                    b.Property<string>("StudentUserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentCourseId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentAverageMark")
                        .HasColumnType("int");

                    b.Property<int>("StudentFinalMark")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("StudentMidTermMark")
                        .HasColumnType("int");

                    b.HasKey("StudentCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentsCourses");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<DateTime>("TeacherCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeacherEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TeacherPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TeacherSurname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TeacherUserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.Attendance", b =>
                {
                    b.HasOne("StudentTrackingApplicationReal.Shared.Models.StudentCourse", "StudentCourse")
                        .WithMany()
                        .HasForeignKey("StudentCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentCourse");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.Course", b =>
                {
                    b.HasOne("StudentTrackingApplicationReal.Shared.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("StudentTrackingApplicationReal.Shared.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentTrackingApplicationReal.Shared.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentTrackingApplicationReal.Shared.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}