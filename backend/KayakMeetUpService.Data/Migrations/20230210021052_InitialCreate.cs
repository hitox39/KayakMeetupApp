using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KayakMeetUpService.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BoatId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "User",
                type: "int",
                maxLength: 15,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "User",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Boat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearMade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CasualMeetUpEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    ZipCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Latitude = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    Longitude = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasualMeetUpEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishingTournamentEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(95)", maxLength: 95, nullable: false),
                    State = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    ZipCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Latitude = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    Longitude = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrizePool = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingTournamentEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaceEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(95)", maxLength: 95, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    ZipCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Latitude = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    Longitude = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrizePool = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceEvent", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_BoatId",
                table: "User",
                column: "BoatId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Boat_BoatId",
                table: "User",
                column: "BoatId",
                principalTable: "Boat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Boat_BoatId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Boat");

            migrationBuilder.DropTable(
                name: "CasualMeetUpEvent");

            migrationBuilder.DropTable(
                name: "FishingTournamentEvent");

            migrationBuilder.DropTable(
                name: "RaceEvent");

            migrationBuilder.DropIndex(
                name: "IX_User_BoatId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BoatId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "State",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "User");
        }
    }
}
