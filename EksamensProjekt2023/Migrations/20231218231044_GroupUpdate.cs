using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjekt2023.Migrations
{
    /// <inheritdoc />
    public partial class GroupUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_GroupLeaderId",
                table: "Groups");

            migrationBuilder.AlterColumn<string>(
                name: "GroupLeaderId",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_GroupLeaderId",
                table: "Groups");

            migrationBuilder.AlterColumn<string>(
                name: "GroupLeaderId",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
