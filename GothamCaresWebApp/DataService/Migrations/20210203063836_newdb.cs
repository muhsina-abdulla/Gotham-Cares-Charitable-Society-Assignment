using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataService.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Outlets",
                columns: table => new
                {
                    OutletId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    Landmark = table.Column<string>(type: "text", nullable: false),
                    AvailableFoodPackets = table.Column<int>(type: "integer", nullable: false),
                    FoodType = table.Column<string>(type: "text", nullable: false),
                    RequiredVolunteers = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outlets", x => x.OutletId);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    OutletId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volunteers_Outlets_OutletId",
                        column: x => x.OutletId,
                        principalTable: "Outlets",
                        principalColumn: "OutletId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Email", "Password" },
                values: new object[,]
                {
                    { "muhsina-abdulla@gmail.com", "muhsina-abdulla" },
                    { "tom-hanks@gmail.com", "tom-hanks" },
                    { "jonna-jinton@gmial.com", "jonna-jinton" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_OutletId",
                table: "Volunteers",
                column: "OutletId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Outlets");
        }
    }
}
