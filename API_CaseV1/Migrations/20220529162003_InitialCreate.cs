using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_CaseV1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adressen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Straat = table.Column<string>(type: "TEXT", nullable: true),
                    Huisnummer = table.Column<int>(type: "INTEGER", nullable: false),
                    Postcode = table.Column<string>(type: "TEXT", nullable: true),
                    Plaats = table.Column<string>(type: "TEXT", nullable: true),
                    Land = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adressen", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Adressen",
                columns: new[] { "Id", "Huisnummer", "Land", "Plaats", "Postcode", "Straat" },
                values: new object[] { 1L, 20, "Nederland", "Purmerend", "1446BE", "binnendijk" });

            migrationBuilder.InsertData(
                table: "Adressen",
                columns: new[] { "Id", "Huisnummer", "Land", "Plaats", "Postcode", "Straat" },
                values: new object[] { 2L, 31, "Nederland", "Amsterdam", "1012PC", "kalverstraat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adressen");
        }
    }
}
