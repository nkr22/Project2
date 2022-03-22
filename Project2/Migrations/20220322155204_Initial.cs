using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    SlotId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Month = table.Column<string>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    Hour = table.Column<string>(nullable: false),
                    Filled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.SlotId);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    SlotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_Times_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Times",
                        principalColumn: "SlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 1, 28, false, "8:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 66, 2, false, "8:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 65, 1, false, "8:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 64, 1, false, "7:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 63, 1, false, "6:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 62, 1, false, "5:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 61, 1, false, "4:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 60, 1, false, "3:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 59, 1, false, "2:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 58, 1, false, "1:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 57, 1, false, "12:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 56, 1, false, "11:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 55, 1, false, "10:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 54, 1, false, "9:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 53, 1, false, "8:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 52, 31, false, "8:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 51, 31, false, "7:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 50, 31, false, "6:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 49, 31, false, "5:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 48, 31, false, "4:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 67, 2, false, "9:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 47, 31, false, "3:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 68, 2, false, "10:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 70, 2, false, "12:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 89, 3, false, "6:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 88, 3, false, "5:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 87, 3, false, "4:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 86, 3, false, "3:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 85, 3, false, "2:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 84, 3, false, "1:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 83, 3, false, "12:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 82, 3, false, "11:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 81, 3, false, "10:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 80, 3, false, "9:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 79, 3, false, "8:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 78, 2, false, "8:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 77, 2, false, "7:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 76, 2, false, "6:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 75, 2, false, "5:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 74, 2, false, "4:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 73, 2, false, "3:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 72, 2, false, "2:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 71, 2, false, "1:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 69, 2, false, "11:00 AM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 90, 3, false, "7:00 PM", "April" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 46, 31, false, "2:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 44, 31, false, "12:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 20, 29, false, "2:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 19, 29, false, "1:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 18, 29, false, "12:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 17, 29, false, "11:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 16, 29, false, "10:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 15, 29, false, "9:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 14, 29, false, "8:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 13, 28, false, "8:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 12, 28, false, "7:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 11, 28, false, "6:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 10, 28, false, "5:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 9, 28, false, "4:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 8, 28, false, "3:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 7, 28, false, "2:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 6, 28, false, "1:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 5, 28, false, "12:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 4, 28, false, "11:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 3, 28, false, "10:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 2, 28, false, "9:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 21, 29, false, "3:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 45, 31, false, "1:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 22, 29, false, "4:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 24, 29, false, "6:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 43, 31, false, "11:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 42, 31, false, "10:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 41, 31, false, "9:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 40, 31, false, "8:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 39, 30, false, "8:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 38, 30, false, "7:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 37, 30, false, "6:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 36, 30, false, "5:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 35, 30, false, "4:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 34, 30, false, "3:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 33, 30, false, "2:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 32, 30, false, "1:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 31, 30, false, "12:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 30, 30, false, "11:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 29, 30, false, "10:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 28, 30, false, "9:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 27, 30, false, "8:00 AM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 26, 29, false, "8:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 25, 29, false, "7:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 23, 29, false, "5:00 PM", "March" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "SlotId", "Day", "Filled", "Hour", "Month" },
                values: new object[] { 91, 3, false, "8:00 PM", "April" });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_SlotId",
                table: "Tours",
                column: "SlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
