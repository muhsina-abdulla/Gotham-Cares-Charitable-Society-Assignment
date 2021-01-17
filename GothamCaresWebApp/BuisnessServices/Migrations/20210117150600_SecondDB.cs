using Microsoft.EntityFrameworkCore.Migrations;

namespace BuisnessServices.Migrations
{
    public partial class SecondDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Volunteers_Outlets_OutletId",
                table: "Volunteers");

            migrationBuilder.DropIndex(
                name: "IX_Volunteers_OutletId",
                table: "Volunteers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_OutletId",
                table: "Volunteers",
                column: "OutletId");

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteers_Outlets_OutletId",
                table: "Volunteers",
                column: "OutletId",
                principalTable: "Outlets",
                principalColumn: "OutletId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
