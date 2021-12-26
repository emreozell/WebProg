using Microsoft.EntityFrameworkCore.Migrations;

namespace WebOdev.Migrations
{
    public partial class asasdaffdddas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SepetDetay");

            migrationBuilder.DropTable(
                name: "Sepet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    SepetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SepetFiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.SepetId);
                    table.ForeignKey(
                        name: "FK_Sepet_AspNetUsers_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SepetDetay",
                columns: table => new
                {
                    SepetDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SepetId = table.Column<int>(type: "int", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false),
                    UrunNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SepetDetay", x => x.SepetDetayId);
                    table.ForeignKey(
                        name: "FK_SepetDetay_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SepetDetay_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "SepetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_KullaniciId",
                table: "Sepet",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_SepetDetay_FoodID",
                table: "SepetDetay",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_SepetDetay_SepetId",
                table: "SepetDetay",
                column: "SepetId");
        }
    }
}
