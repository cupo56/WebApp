using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iScent.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parfums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Marke = table.Column<string>(type: "TEXT", nullable: true),
                    Beschreibung = table.Column<string>(type: "TEXT", nullable: true),
                    Kopfnote = table.Column<string>(type: "TEXT", nullable: true),
                    Herznote = table.Column<string>(type: "TEXT", nullable: true),
                    Basisnote = table.Column<string>(type: "TEXT", nullable: true),
                    BildUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parfums", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parfums");
        }
    }
}
