﻿// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200302111127_Refactor")]
    partial class Refactor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Data.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Difficulty")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<DateTimeOffset?>("EndTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("PriorityId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("StartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("PriorityId");

                    b.HasIndex("TeamId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("BackEnd.Data.AssignmentTag", b =>
                {
                    b.Property<int>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<int>("TagID")
                        .HasColumnType("int");

                    b.HasKey("AssignmentID", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("AssignmentTag");
                });

            modelBuilder.Entity("BackEnd.Data.AssignmentWatcher", b =>
                {
                    b.Property<int>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<int>("WatcherID")
                        .HasColumnType("int");

                    b.HasKey("AssignmentID", "WatcherID");

                    b.HasIndex("WatcherID");

                    b.ToTable("AssignmentWatcher");
                });

            modelBuilder.Entity("BackEnd.Data.CurrentWorker", b =>
                {
                    b.Property<int>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<int>("WorkerID")
                        .HasColumnType("int");

                    b.HasKey("AssignmentID", "WorkerID");

                    b.HasIndex("WorkerID");

                    b.ToTable("CurrentWorker");
                });

            modelBuilder.Entity("BackEnd.Data.Priority", b =>
                {
                    b.Property<int>("PriorityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("PriorityID");

                    b.HasIndex("TeamID");

                    b.ToTable("Priorities");
                });

            modelBuilder.Entity("BackEnd.Data.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("ID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BackEnd.Data.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BackEnd.Data.TeamWatcher", b =>
                {
                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("WatcherID")
                        .HasColumnType("int");

                    b.HasKey("TeamID", "WatcherID");

                    b.HasIndex("WatcherID");

                    b.ToTable("TeamWatcher");
                });

            modelBuilder.Entity("BackEnd.Data.Watcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Watchers");
                });

            modelBuilder.Entity("BackEnd.Data.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("WebPage")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("BackEnd.Data.Assignment", b =>
                {
                    b.HasOne("BackEnd.Data.Priority", "Priority")
                        .WithMany("Tasks")
                        .HasForeignKey("PriorityId");

                    b.HasOne("BackEnd.Data.Team", "Team")
                        .WithMany("Assignments")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("BackEnd.Data.AssignmentTag", b =>
                {
                    b.HasOne("BackEnd.Data.Assignment", "Assignment")
                        .WithMany("AssignmentTags")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Data.Tag", "Tag")
                        .WithMany("AssignmentTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Data.AssignmentWatcher", b =>
                {
                    b.HasOne("BackEnd.Data.Assignment", "Assignment")
                        .WithMany()
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Data.Watcher", "Watcher")
                        .WithMany("AssignmentWatchers")
                        .HasForeignKey("WatcherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Data.CurrentWorker", b =>
                {
                    b.HasOne("BackEnd.Data.Assignment", "Assignment")
                        .WithMany("CurrentWorkers")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Data.Worker", "Worker")
                        .WithMany("CurrentWorkers")
                        .HasForeignKey("WorkerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Data.Priority", b =>
                {
                    b.HasOne("BackEnd.Data.Team", "Team")
                        .WithMany("Priorities")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Data.TeamWatcher", b =>
                {
                    b.HasOne("BackEnd.Data.Team", "Team")
                        .WithMany("TeamWatchers")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Data.Watcher", "Watcher")
                        .WithMany("TeamWatchers")
                        .HasForeignKey("WatcherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Data.Worker", b =>
                {
                    b.HasOne("BackEnd.Data.Team", null)
                        .WithMany("Workers")
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}