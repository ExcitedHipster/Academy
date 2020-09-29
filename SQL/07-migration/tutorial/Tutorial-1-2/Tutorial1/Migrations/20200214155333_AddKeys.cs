using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial1.Migrations
{
    public partial class AddKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "University",
                table: "Agreemant");

            migrationBuilder.CreateTable(
                name: "AgreemantUniversity",
                columns: table => new
                {
                    AgreemantId = table.Column<int>(nullable: false),
                    UniversityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreemantUniversity", x => new { x.AgreemantId, x.UniversityId });
                    table.ForeignKey(
                        name: "FK_AgreemantUniversity_University_AgreemantId",
                        column: x => x.AgreemantId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgreemantUniversity_Agreemant_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Agreemant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreemantUniversity_UniversityId",
                table: "AgreemantUniversity",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreemantUniversity");

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Agreemant",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
