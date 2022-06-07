using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrenciProjesi.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrencis_Bolums_BolumlerBolumId",
                table: "Ogrencis");

            migrationBuilder.RenameColumn(
                name: "BolumlerBolumId",
                table: "Ogrencis",
                newName: "BolumId1");

            migrationBuilder.RenameColumn(
                name: "BolumAdi",
                table: "Ogrencis",
                newName: "BolumId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrencis_BolumlerBolumId",
                table: "Ogrencis",
                newName: "IX_Ogrencis_BolumId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrencis_Bolums_BolumId1",
                table: "Ogrencis",
                column: "BolumId1",
                principalTable: "Bolums",
                principalColumn: "BolumId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrencis_Bolums_BolumId1",
                table: "Ogrencis");

            migrationBuilder.RenameColumn(
                name: "BolumId1",
                table: "Ogrencis",
                newName: "BolumlerBolumId");

            migrationBuilder.RenameColumn(
                name: "BolumId",
                table: "Ogrencis",
                newName: "BolumAdi");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrencis_BolumId1",
                table: "Ogrencis",
                newName: "IX_Ogrencis_BolumlerBolumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrencis_Bolums_BolumlerBolumId",
                table: "Ogrencis",
                column: "BolumlerBolumId",
                principalTable: "Bolums",
                principalColumn: "BolumId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
