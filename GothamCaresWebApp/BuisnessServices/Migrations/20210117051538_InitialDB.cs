using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BuisnessServices.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: true)
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
                    Name = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    Landmark = table.Column<string>(type: "text", nullable: true),
                    FoodPackets = table.Column<int>(type: "integer", nullable: false),
                    FoodType = table.Column<string>(type: "text", nullable: true),
                    RequiredVolunteers = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: true)
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
                    Name = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    OutletId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: true)
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
                    { 1, "19/01/2021", 78, "Non Veg", "ABC Store", "Rose", 7, "ABC" },
                    { 2, "18/01/2021", 100, "Veg", "DEF Store", "Lily", 10, "DEF" },
                    { 3, "18/01/2021", 110, "Both", "GHI Store", "Jasmine", 11, "GHI" },
                    { 4, "17/01/2021", 200, "Veg", "JKL Store", "Lavender", 20, "JKL" },
                    { 5, "17/01/2021", 400, "Veg", "MNO Store", "Orchid", 40, "MNO" }
                });

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "Id", "Date", "Name", "OutletId", "Phone", "email" },
                values: new object[,]
                {
                    { 1, "15/01/2021", "Muhsina", 1, 86066244485L, "muhsinabinthabdulla@gmail.com" },
                    { 2, "16/01/2021", "Hepzibha", 1, 98204928902L, "Hepzibha@gmail.com" },
                    { 3, "17/01/2021", "Priya", 1, 5864564025L, "Prya@gmail.com" },
                    { 4, "15/01/2021", "Megha", 2, 89208374890L, "Megha@gmail.com" },
                    { 5, "17/01/2021", "Navneeth", 5, 9820328902L, "FantomPhreak@gmail.com" }
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
