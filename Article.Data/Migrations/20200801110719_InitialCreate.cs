using Microsoft.EntityFrameworkCore.Migrations;

namespace MyArticle.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WritterId = table.Column<string>(nullable: true),
                    Topic = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    WritterName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Type = table.Column<int>(nullable: false),
                    MiniView = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ArticleDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}
