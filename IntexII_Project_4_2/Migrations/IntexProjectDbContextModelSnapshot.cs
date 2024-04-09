﻿// <auto-generated />
using System;
using IntexII_Project_4_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntexII_Project_4_2.Migrations
{
    [DbContext(typeof(IntexProjectDbContext))]
    partial class IntexProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IntexII_Project_4_2.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_ID");

                    b.Property<double>("Age")
                        .HasColumnType("float")
                        .HasColumnName("age");

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("birth_date");

                    b.Property<string>("CountryOfResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_of_residence");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("IntexII_Project_4_2.Models.LineItem", b =>
                {
                    b.Property<int>("TransactionId")
                        .HasColumnType("int")
                        .HasColumnName("transaction_ID");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_ID");

                    b.Property<int>("Qty")
                        .HasColumnType("int")
                        .HasColumnName("qty");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.HasKey("TransactionId", "ProductId");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("IntexII_Project_4_2.Models.Order", b =>
                {
                    b.Property<int>("TransactionId")
                        .HasColumnType("int")
                        .HasColumnName("transaction_ID");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<string>("Bank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("bank");

                    b.Property<string>("CountryOfTransaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_of_transaction");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_ID");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("date");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("day_of_week");

                    b.Property<string>("EntryMode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("entry_mode");

                    b.Property<int>("Fraud")
                        .HasColumnType("int")
                        .HasColumnName("fraud");

                    b.Property<bool>("Fullfilled")
                        .HasColumnType("bit");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("shipping_address");

                    b.Property<int>("Time")
                        .HasColumnType("int")
                        .HasColumnName("time");

                    b.Property<string>("TypeOfCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type_of_card");

                    b.Property<string>("TypeOfTransaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type_of_transaction");

                    b.HasKey("TransactionId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("IntexII_Project_4_2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_ID");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("ImgLink")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("img_link");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int?>("NumParts")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("num_parts");

                    b.Property<int?>("Price")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<string>("PrimaryColor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("primary_color");

                    b.Property<string>("SecondaryColor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("secondary_color");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("int")
                        .HasColumnName("year");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
