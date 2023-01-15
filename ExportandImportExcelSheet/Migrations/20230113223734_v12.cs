using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExportandImportExcelSheet.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Schoole_Student",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Student",
                table: "Student",
                newName: "SchooleId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Student",
                table: "Student",
                newName: "IX_Student_SchooleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Schoole_SchooleId",
                table: "Student",
                column: "SchooleId",
                principalTable: "Schoole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Schoole_SchooleId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "SchooleId",
                table: "Student",
                newName: "Student");

            migrationBuilder.RenameIndex(
                name: "IX_Student_SchooleId",
                table: "Student",
                newName: "IX_Student_Student");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Schoole_Student",
                table: "Student",
                column: "Student",
                principalTable: "Schoole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
