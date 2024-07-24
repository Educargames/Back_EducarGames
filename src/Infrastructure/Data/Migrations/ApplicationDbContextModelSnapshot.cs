﻿// <auto-generated />
using System;
using Educar.Backend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Educar.Backend.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<decimal>("AverageScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(5,2)")
                        .HasDefaultValue(0m)
                        .HasColumnName("average_score");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<decimal>("EventAverageScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(5,2)")
                        .HasDefaultValue(0m)
                        .HasColumnName("event_average_score");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("registration_number");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("role");

                    b.Property<Guid?>("SchoolId")
                        .HasColumnType("uuid")
                        .HasColumnName("school_id");

                    b.Property<int>("Stars")
                        .HasColumnType("integer")
                        .HasColumnName("stars");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SchoolId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.AccountClass", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid")
                        .HasColumnName("account_id");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uuid")
                        .HasColumnName("class_id");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.HasKey("AccountId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("account_classes");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("country");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<decimal?>("Lat")
                        .HasColumnType("decimal(9,6)")
                        .HasColumnName("lat");

                    b.Property<decimal?>("Lng")
                        .HasColumnType("decimal(9,6)")
                        .HasColumnName("lng");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("postal_code");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("state");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("street");

                    b.HasKey("Id");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("purpose");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uuid")
                        .HasColumnName("school_id");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<int>("ContractDurationInYears")
                        .HasColumnType("integer")
                        .HasColumnName("contract_duration_in_years");

                    b.Property<DateTimeOffset>("ContractSigningDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("contract_signing_date");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("DeliveryReport")
                        .HasColumnType("text")
                        .HasColumnName("delivery_report");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uuid")
                        .HasColumnName("game_id");

                    b.Property<DateTimeOffset>("ImplementationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("implementation_date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<int?>("RemainingAccounts")
                        .HasColumnType("integer")
                        .HasColumnName("remaining_accounts");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<int>("TotalAccounts")
                        .HasColumnType("integer")
                        .HasColumnName("total_accounts");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("GameId");

                    b.ToTable("contracts");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Lore")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lore");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("purpose");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("games");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.GameSubject", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("uuid")
                        .HasColumnName("game_id");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("subject_id");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.HasKey("GameId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("game_subjects");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Grade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("grades");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Agreement")
                        .HasColumnType("boolean")
                        .HasColumnName("agreement");

                    b.Property<string>("Author")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("author");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("ObjectName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("object_name");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("purpose");

                    b.Property<string>("References")
                        .HasColumnType("text")
                        .HasColumnName("references");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("medias");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.MediaLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid")
                        .HasColumnName("account_id");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("action");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("CurrentState")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("current_state");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("uuid")
                        .HasColumnName("media_id");

                    b.Property<string>("PreviousState")
                        .HasColumnType("jsonb")
                        .HasColumnName("previous_state");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("MediaId");

                    b.ToTable("media_logs");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uuid")
                        .HasColumnName("address_id");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ClientId");

                    b.ToTable("schools");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Account", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Client", "Client")
                        .WithMany("Accounts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Educar.Backend.Domain.Entities.School", "School")
                        .WithMany("Accounts")
                        .HasForeignKey("SchoolId");

                    b.Navigation("Client");

                    b.Navigation("School");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.AccountClass", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Account", "Account")
                        .WithMany("AccountClasses")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Educar.Backend.Domain.Entities.Class", "Class")
                        .WithMany("AccountClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Class", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Contract", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Client", "Client")
                        .WithMany("Contracts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Educar.Backend.Domain.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.GameSubject", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Game", "Game")
                        .WithMany("GameSubjects")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Educar.Backend.Domain.Entities.Subject", "Subject")
                        .WithMany("GameSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.MediaLog", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Educar.Backend.Domain.Entities.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Media");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.School", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Educar.Backend.Domain.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Account", b =>
                {
                    b.Navigation("AccountClasses");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Class", b =>
                {
                    b.Navigation("AccountClasses");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Client", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Game", b =>
                {
                    b.Navigation("GameSubjects");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.School", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Subject", b =>
                {
                    b.Navigation("GameSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
