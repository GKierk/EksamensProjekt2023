using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjekt2023.Migrations
{
    /// <inheritdoc />
    public partial class UserProfileFix4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "AspNetUsers",
                newName: "user_type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "user_type",
                table: "AspNetUsers",
                newName: "Discriminator");
        }
    }
}
