using Microsoft.EntityFrameworkCore.Migrations;

namespace Group2.Migrations
{
    public partial class clemo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 50, nullable: false),
                    catname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "doc_Res",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    fULL_NAME = table.Column<string>(nullable: false),
                    uSERNAME = table.Column<string>(nullable: false),
                    ROLE = table.Column<string>(nullable: true),
                    serviceNo = table.Column<string>(nullable: false),
                    PHONE = table.Column<string>(nullable: false),
                    PASSWORD = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doc_Res", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 50, nullable: false),
                    Role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "userDetails",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    UswerId = table.Column<string>(nullable: false),
                    date = table.Column<string>(nullable: false),
                    DocId = table.Column<string>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    IsDiagnosed = table.Column<string>(nullable: true),
                    Problem = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    fULL_NAME = table.Column<string>(nullable: false),
                    d_O_b = table.Column<string>(nullable: false),
                    GENDER = table.Column<string>(nullable: false),
                    uSERNAME = table.Column<string>(nullable: false),
                    ROLE = table.Column<string>(nullable: false),
                    uniqueId = table.Column<string>(nullable: false),
                    LOCATION = table.Column<string>(nullable: false),
                    PHONE = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "doc_Res");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "userDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
