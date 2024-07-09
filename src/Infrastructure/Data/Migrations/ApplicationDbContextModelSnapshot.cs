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

                    b.Property<int>("Stars")
                        .HasColumnType("integer")
                        .HasColumnName("stars");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("account");
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

                    b.ToTable("client");
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

                    b.ToTable("contract");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.TodoItem", b =>
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

                    b.Property<bool>("Done")
                        .HasColumnType("boolean")
                        .HasColumnName("done");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<Guid>("ListId")
                        .HasColumnType("uuid")
                        .HasColumnName("list_id");

                    b.Property<string>("Note")
                        .HasColumnType("text")
                        .HasColumnName("note");

                    b.Property<DateTime?>("Reminder")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("reminder");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("todo_item");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.TodoList", b =>
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("todo_list");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Account", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Client", "Client")
                        .WithMany("Accounts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Contract", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.Client", "Client")
                        .WithMany("Contracts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.TodoItem", b =>
                {
                    b.HasOne("Educar.Backend.Domain.Entities.TodoList", "List")
                        .WithMany("Items")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("List");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.Client", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Educar.Backend.Domain.Entities.TodoList", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
