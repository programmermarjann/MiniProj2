using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniProj2.Migrations
{
    public partial class CreateMiniProj2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laptops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mobilePhones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonePurchaseDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mobilePhones", x => x.PhoneId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "laptops");

            migrationBuilder.DropTable(
                name: "mobilePhones");
        }
    }
}
