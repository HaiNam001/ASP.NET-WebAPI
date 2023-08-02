﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPILesson.Data;

#nullable disable

namespace WebAPILesson.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPILesson.Data.Course", b =>
                {
                    b.Property<int>("course_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("course_id"), 1L, 1);

                    b.Property<string>("course_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<DateTime>("schedule")
                        .HasColumnType("datetime2");

                    b.HasKey("course_id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebAPILesson.Data.CourseEnrollment", b =>
                {
                    b.Property<int>("courenroll_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("courenroll_id"), 1L, 1);

                    b.Property<int>("course_id")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("money");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("courenroll_id");

                    b.HasIndex("course_id");

                    b.HasIndex("user_id");

                    b.ToTable("CourseEnrollments", (string)null);
                });

            modelBuilder.Entity("WebAPILesson.Data.Gears", b =>
                {
                    b.Property<int>("gear_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gear_id"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("grear_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("image_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("gear_id");

                    b.ToTable("Gears");
                });

            modelBuilder.Entity("WebAPILesson.Data.Gym", b =>
                {
                    b.Property<int>("gym_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gym_id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("gym_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("website_url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("gym_id");

                    b.ToTable("Gyms", (string)null);
                });

            modelBuilder.Entity("WebAPILesson.Data.GymBooking", b =>
                {
                    b.Property<int>("booking_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("booking_id"), 1L, 1);

                    b.Property<DateTime>("booking_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("gym_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("booking_id");

                    b.HasIndex("gym_id");

                    b.HasIndex("user_id");

                    b.ToTable("GymBookings", (string)null);
                });

            modelBuilder.Entity("WebAPILesson.Data.New", b =>
                {
                    b.Property<int>("news_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("news_id"), 1L, 1);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("publish_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("news_id");

                    b.ToTable("News", (string)null);
                });

            modelBuilder.Entity("WebAPILesson.Data.Order", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("order_id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("order_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("order_status")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("total_amount")
                        .HasColumnType("money");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("order_id");

                    b.HasIndex("user_id");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("WebAPILesson.Data.OrderItem", b =>
                {
                    b.Property<int>("item_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("item_id"), 1L, 1);

                    b.Property<int>("gear_id")
                        .HasColumnType("int");

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("item_id");

                    b.HasIndex("gear_id");

                    b.HasIndex("order_id");

                    b.ToTable("OrderItems", (string)null);
                });

            modelBuilder.Entity("WebAPILesson.Data.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("user_id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("WebAPILesson.Data.CourseEnrollment", b =>
                {
                    b.HasOne("WebAPILesson.Data.Course", "course")
                        .WithMany("courseEnrollments")
                        .HasForeignKey("course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CourseEnrollment_Course");

                    b.HasOne("WebAPILesson.Data.User", "user")
                        .WithMany("courseEnrollments")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CourseEnrollment_User");

                    b.Navigation("course");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebAPILesson.Data.GymBooking", b =>
                {
                    b.HasOne("WebAPILesson.Data.Gym", "gym")
                        .WithMany("gymBookings")
                        .HasForeignKey("gym_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GymBooking_Gym");

                    b.HasOne("WebAPILesson.Data.User", "user")
                        .WithMany("gymBookings")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GymBooking_User");

                    b.Navigation("gym");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebAPILesson.Data.Order", b =>
                {
                    b.HasOne("WebAPILesson.Data.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebAPILesson.Data.OrderItem", b =>
                {
                    b.HasOne("WebAPILesson.Data.Gears", "gears")
                        .WithMany("orderItems")
                        .HasForeignKey("gear_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_OrderItem_Gear");

                    b.HasOne("WebAPILesson.Data.Order", "order")
                        .WithMany("orderItems")
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_OrderItem_Order");

                    b.Navigation("gears");

                    b.Navigation("order");
                });

            modelBuilder.Entity("WebAPILesson.Data.Course", b =>
                {
                    b.Navigation("courseEnrollments");
                });

            modelBuilder.Entity("WebAPILesson.Data.Gears", b =>
                {
                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("WebAPILesson.Data.Gym", b =>
                {
                    b.Navigation("gymBookings");
                });

            modelBuilder.Entity("WebAPILesson.Data.Order", b =>
                {
                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("WebAPILesson.Data.User", b =>
                {
                    b.Navigation("courseEnrollments");

                    b.Navigation("gymBookings");

                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
