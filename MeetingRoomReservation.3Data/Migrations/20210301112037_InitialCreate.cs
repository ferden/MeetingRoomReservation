using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingRoomReservation._3Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PersonCapacity = table.Column<int>(type: "int", nullable: false),
                    Projection = table.Column<bool>(type: "bit", nullable: false),
                    Computer = table.Column<bool>(type: "bit", nullable: false),
                    WebConference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PlaceID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingRooms_Places_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeetingSubject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MeetingType = table.Column<int>(type: "int", nullable: false),
                    MeetingDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MeetingStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeetingEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeetingNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    MeetingRoomID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_MeetingRooms_MeetingRoomID",
                        column: x => x.MeetingRoomID,
                        principalTable: "MeetingRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "initial", new DateTime(2021, 3, 1, 14, 20, 36, 695, DateTimeKind.Local).AddTicks(2218), true, false, "Initial", new DateTime(2021, 3, 1, 14, 20, 36, 695, DateTimeKind.Local).AddTicks(3109), "TOBB AZ Yerleşkesi2", "Initial" });

            migrationBuilder.InsertData(
                table: "MeetingRooms",
                columns: new[] { "Id", "Area", "Computer", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "PersonCapacity", "PlaceID", "Projection", "Status", "WebConference" },
                values: new object[] { 1, 10, true, "initial", new DateTime(2021, 3, 1, 14, 20, 36, 700, DateTimeKind.Local).AddTicks(3135), "Buyuk Salon2", true, false, "Initial", new DateTime(2021, 3, 1, 14, 20, 36, 700, DateTimeKind.Local).AddTicks(3145), "1 nolu Salon2", "note", 12, 1, true, 1, "zoom" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "MeetingDescription", "MeetingEndTime", "MeetingNotes", "MeetingRoomID", "MeetingStartTime", "MeetingSubject", "MeetingType", "ModifiedByName", "ModifiedDate", "Note", "RequestUser" },
                values: new object[] { 1, "initial", new DateTime(2021, 3, 1, 14, 20, 36, 702, DateTimeKind.Local).AddTicks(4353), true, false, "Test Desc Topantisi", new DateTime(2021, 3, 1, 14, 50, 36, 702, DateTimeKind.Local).AddTicks(3138), "Notlar", 1, new DateTime(2021, 3, 1, 14, 20, 36, 702, DateTimeKind.Local).AddTicks(2822), "test toplanti Basliği", 1, "initial", new DateTime(2021, 3, 1, 14, 20, 36, 702, DateTimeKind.Local).AddTicks(4045), "Not", "fikret.erden" });

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRooms_PlaceID",
                table: "MeetingRooms",
                column: "PlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MeetingRoomID",
                table: "Reservations",
                column: "MeetingRoomID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "MeetingRooms");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
