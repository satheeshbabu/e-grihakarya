﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace egrihakarya.Migrations
{
    [DbContext(typeof(ClassroomContext))]
    [Migration("20190814100612_GetAssignmentByUserAndAssID")]
    partial class GetAssignmentByUserAndAssID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CAS.Assignment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddedOn");

                    b.Property<string>("Attachment");

                    b.Property<int?>("CASClassId");

                    b.Property<int>("ClassID");

                    b.Property<int?>("CreateById");

                    b.Property<string>("DueDate");

                    b.Property<string>("Instructions");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("CASClassId");

                    b.HasIndex("CreateById");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("CAS.CASClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectCode");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("CAS.Comments", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentID");

                    b.Property<string>("Comment");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CAS.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("Token");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CAS.UserClass", b =>
                {
                    b.Property<int>("UserClassID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassID");

                    b.Property<int>("UserID");

                    b.HasKey("UserClassID");

                    b.HasIndex("ClassID");

                    b.HasIndex("UserID");

                    b.ToTable("UserClass");
                });

            modelBuilder.Entity("CAS.Assignment", b =>
                {
                    b.HasOne("CAS.CASClass")
                        .WithMany("Assignment")
                        .HasForeignKey("CASClassId");

                    b.HasOne("CAS.User", "CreateBy")
                        .WithMany("Assignments")
                        .HasForeignKey("CreateById");
                });

            modelBuilder.Entity("CAS.Comments", b =>
                {
                    b.HasOne("CAS.Assignment", "Assignment")
                        .WithMany("Comments")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAS.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAS.UserClass", b =>
                {
                    b.HasOne("CAS.CASClass", "Class")
                        .WithMany("UserClass")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAS.User", "User")
                        .WithMany("UserClass")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
