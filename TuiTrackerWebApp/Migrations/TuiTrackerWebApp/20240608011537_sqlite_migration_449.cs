using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TuiTrackerWebApp.Migrations.TuiTrackerWebApp
{
    /// <inheritdoc />
    public partial class sqlite_migration_449 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PrimaryContactId = table.Column<int>(type: "INTEGER", nullable: false),
                    AccountsContactId = table.Column<int>(type: "INTEGER", nullable: false),
                    NZBN = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    IsSupplier = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    BusinessId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Business_AccountsContactId",
                table: "Business",
                column: "AccountsContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_PrimaryContactId",
                table: "Business",
                column: "PrimaryContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_BusinessId",
                table: "Contact",
                column: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_Contact_AccountsContactId",
                table: "Business",
                column: "AccountsContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Business_Contact_PrimaryContactId",
                table: "Business",
                column: "PrimaryContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Business_Contact_AccountsContactId",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_Contact_PrimaryContactId",
                table: "Business");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Business");
        }
    }
}
