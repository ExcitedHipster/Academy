using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice_1.Migrations
{
    public partial class CompanyDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emploies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emploies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TBC" },
                    { 2, "Bank of Georgia" },
                    { 3, "Dunder mifflin" }
                });

            migrationBuilder.InsertData(
                table: "Emploies",
                columns: new[] { "Id", "CompanyId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 1, "gigi10@gmail.com", "Gigi", "995-75-75-75" },
                    { 2, 1, "Lika_lika@gmail.com", "Lika", "456-35-23-43" },
                    { 3, 3, "Tekla-Tek-Tek@gmail.com", "Tekla", "123-12-32-44" },
                    { 4, 1, "Pam@gmail.com", "Pam", "234156454" },
                    { 5, 4, "Andrii@gmail.com", "Andrii", "1234-234-234" },
                    { 6, 4, "Sergii@gmail.com", "Sergii", "123-544-123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Emploies");
        }
    }
}
