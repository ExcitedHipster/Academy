using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial1.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agreemant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    IsAgree = table.Column<bool>(nullable: false),
                    University = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreemant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "University",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ivane Javakhishvili Tbilisi State University" },
                    { 2, "Tbilisi Independent University" },
                    { 3, "Tbilisi State Medical University" },
                    { 4, "Caucasus University" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agreemant");

            migrationBuilder.DropTable(
                name: "University");
        }
    }
}
