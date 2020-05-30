using Microsoft.EntityFrameworkCore.Migrations;

namespace RPTSobj.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RPTSobjs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    MetroStation = table.Column<string>(nullable: true),
                    MetroLine = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPTSobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 1L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Успенский собор", "http://assumption-cathedral.kreml.ru/" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 2L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Архангельский собор", "http://archangel-cathedral.kreml.ru/" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 3L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Благовещенский собор", "http://annunciation-cathedral.kreml.ru/" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 4L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Патриаршие палаты с церковью Двенадцати апостолов", "http://www.kreml.ru/visit-to-kremlin/what-to-see/patriarshie-palaty-s-tserkovyu-dvenadtsati-apostolov" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RPTSobjs");
        }
    }
}
