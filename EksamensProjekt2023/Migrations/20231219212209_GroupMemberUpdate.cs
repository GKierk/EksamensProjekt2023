using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjekt2023.Migrations
{
    /// <inheritdoc />
    public partial class GroupMemberUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "GroupMembers",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "GroupMembers",
                newName: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_GroupId",
                table: "GroupMembers",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMembers_AspNetUsers_UserProfileId",
                table: "GroupMembers",
                column: "UserProfileId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMembers_Groups_GroupId",
                table: "GroupMembers",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupMembers_AspNetUsers_UserProfileId",
                table: "GroupMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMembers_Groups_GroupId",
                table: "GroupMembers");

            migrationBuilder.DropIndex(
                name: "IX_GroupMembers_GroupId",
                table: "GroupMembers");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "GroupMembers",
                newName: "GroupName");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "GroupMembers",
                newName: "FullName");
        }
    }
}
