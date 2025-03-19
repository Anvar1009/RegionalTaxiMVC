using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegionalTaxiMVC.Migrations
{
    /// <inheritdoc />
    public partial class updateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_brands_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_modelsses_ModelId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Brand_Id",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Model_Id",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Cars",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Cars",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_modelsses_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "modelsses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_brands_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_modelsses_ModelId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Cars",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Cars",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Brand_Id",
                table: "Cars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Model_Id",
                table: "Cars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_modelsses_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "modelsses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
