﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntexII_Project_4_2.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_ID = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_of_residence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "LineItems",
                columns: table => new
                {
                    transaction_ID = table.Column<int>(type: "int", nullable: false),
                    product_ID = table.Column<int>(type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItems", x => new { x.transaction_ID, x.product_ID });
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    transaction_ID = table.Column<int>(type: "int", nullable: false),
                    customer_ID = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day_of_week = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<int>(type: "int", nullable: false),
                    entry_mode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    type_of_transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_of_transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shipping_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_of_card = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fraud = table.Column<int>(type: "int", nullable: false),
                    Fullfilled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.transaction_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_ID = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    num_parts = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    img_link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primary_color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    secondary_color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "LineItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
