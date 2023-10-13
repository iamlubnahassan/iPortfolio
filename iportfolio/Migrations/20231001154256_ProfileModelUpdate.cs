using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iportfolio.Migrations
{
    /// <inheritdoc />
    public partial class ProfileModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "tbl_Profoil",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "tbl_Profoil");
        }
    }
}
