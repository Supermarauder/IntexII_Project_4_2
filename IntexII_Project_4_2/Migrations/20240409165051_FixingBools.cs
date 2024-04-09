using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntexII_Project_4_2.Migrations
{
    /// <inheritdoc />
    public partial class FixingBools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Orders SET Fullfilled = 1 WHERE Fullfilled = 0;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
