using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjekt2023.Migrations
{
    /// <inheritdoc />
    public partial class Groups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_Id",
                table: "Groups");

            migrationBuilder.AddColumn<string>(
                name: "GroupLeaderId",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_GroupLeaderId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_GroupLeaderId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupLeaderId",
                table: "Groups");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_Id",
                table: "Groups",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
