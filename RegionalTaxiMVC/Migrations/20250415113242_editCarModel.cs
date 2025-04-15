using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegionalTaxiMVC.Migrations
{
    /// <inheritdoc />
    public partial class editCarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Car_color",
                table: "Cars",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "Car_type",
                table: "Cars",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Car_type",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "Car_color",
                table: "Cars",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
