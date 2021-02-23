using Microsoft.EntityFrameworkCore.Migrations;

namespace Link.Data.Migrations
{
    public partial class learnerstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "People");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "People");
        }
    }
}
