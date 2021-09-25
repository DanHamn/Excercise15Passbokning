using Microsoft.EntityFrameworkCore.Migrations;

namespace Övning15Passbokning.Data.Data.Migrations
{
    public partial class Booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClass_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserGymClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClass_GymClass_GymClassId",
                table: "ApplicationUserGymClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGymClass",
                table: "ApplicationUserGymClass");

            migrationBuilder.RenameTable(
                name: "ApplicationUserGymClass",
                newName: "ApplicationUserGymClassess");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserGymClass_GymClassId",
                table: "ApplicationUserGymClassess",
                newName: "IX_ApplicationUserGymClassess_GymClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGymClassess",
                table: "ApplicationUserGymClassess",
                columns: new[] { "ApplicationUserId", "GymClassId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClassess_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserGymClassess",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClassess_GymClass_GymClassId",
                table: "ApplicationUserGymClassess",
                column: "GymClassId",
                principalTable: "GymClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClassess_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserGymClassess");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClassess_GymClass_GymClassId",
                table: "ApplicationUserGymClassess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGymClassess",
                table: "ApplicationUserGymClassess");

            migrationBuilder.RenameTable(
                name: "ApplicationUserGymClassess",
                newName: "ApplicationUserGymClass");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserGymClassess_GymClassId",
                table: "ApplicationUserGymClass",
                newName: "IX_ApplicationUserGymClass_GymClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGymClass",
                table: "ApplicationUserGymClass",
                columns: new[] { "ApplicationUserId", "GymClassId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClass_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserGymClass",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClass_GymClass_GymClassId",
                table: "ApplicationUserGymClass",
                column: "GymClassId",
                principalTable: "GymClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
