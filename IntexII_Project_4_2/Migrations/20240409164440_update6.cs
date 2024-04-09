using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntexII_Project_4_2.Migrations
{
    /// <inheritdoc />
    public partial class update6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullfilled",
                table: "Orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Fullfilled",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
