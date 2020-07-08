using Microsoft.EntityFrameworkCore.Migrations;

namespace UserService.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Email", "Name" },
                values: new object[] { 1, 23, "john23@gmail.com", "John" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Email", "Name" },
                values: new object[] { 2, 33, "vijay33@gmail.com", "Vijay" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Email", "Name" },
                values: new object[] { 3, 30, "amit30@gmail.com", "Amit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
