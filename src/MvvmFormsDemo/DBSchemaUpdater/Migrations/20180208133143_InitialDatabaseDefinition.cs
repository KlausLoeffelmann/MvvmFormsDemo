using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DBSchemaUpdater.Migrations
{
    public partial class InitialDatabaseDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kontakte",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateLastEdited = table.Column<DateTimeOffset>(nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    IdEvent = table.Column<Guid>(nullable: false),
                    BookingDate = table.Column<DateTimeOffset>(nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateLastEdited = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Duration = table.Column<long>(nullable: true),
                    EndTime = table.Column<TimeSpan>(nullable: true),
                    KontaktID = table.Column<Guid>(nullable: true),
                    StartTime = table.Column<TimeSpan>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.IdEvent);
                    table.ForeignKey(
                        name: "FK_Events_Kontakte_KontaktID",
                        column: x => x.KontaktID,
                        principalTable: "Kontakte",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_KontaktID",
                table: "Events",
                column: "KontaktID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Kontakte");
        }
    }
}
