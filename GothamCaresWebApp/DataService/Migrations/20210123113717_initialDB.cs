using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataService.Migrations
{
    public partial class initialDB : Migration
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
                    FoodPackets = table.Column<int>(type: "integer", nullable: false),
                    FoodType = table.Column<int>(type: "integer", nullable: false),
                    RequiredVolunteers = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: false)
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
                    { "abcd@gmail.com", "abcd" },
                    { "efgh@gmail.com", "efgh" },
                    { "ijkl@gmail.com", "ijkl" }
                });

            migrationBuilder.InsertData(
                table: "Outlets",
                columns: new[] { "OutletId", "Date", "FoodPackets", "FoodType", "Landmark", "Name", "RequiredVolunteers", "Street" },
                values: new object[,]
                {
                    { 1, "21/01/2020", 78, 1, "ABC Store", "Rose", 7, "ABC" },
                    { 2, "22/01/2020", 100, 0, "DEF Store", "Lily", 10, "DEF" },
                    { 3, "23/01/2020", 110, 2, "GHI Store", "Jasmine", 11, "GHI" },
                    { 4, "24/01/2020", 200, 2, "JKL Store", "Lavender", 20, "JKL" },
                    { 5, "25/01/2020", 400, 0, "MNO Store", "Orchid", 40, "MNO" }
                });

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "Id", "Name", "OutletId", "Phone", "email" },
                values: new object[,]
                {
                    { 1, "Muhsina", 1, 86066244485L, "muhsinabinthabdulla@gmail.com" },
                    { 2, "Hepzibha", 2, 98204928902L, "Hepzibha@gmail.com" },
                    { 3, "Priya", 3, 5864564025L, "Prya@gmail.com" },
                    { 4, "Megha", 4, 89208374890L, "Megha@gmail.com" },
                    { 5, "Navneeth", 5, 9820328902L, "FantomPhreak@gmail.com" }
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
