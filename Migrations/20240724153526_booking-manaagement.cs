using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace e_booking.Migrations
{
    /// <inheritdoc />
    public partial class bookingmanaagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hall_capacities",
                columns: table => new
                {
                    HallName = table.Column<string>(type: "varchar(255)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hall_capacities", x => x.HallName);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "time_table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HallName = table.Column<string>(type: "longtext", nullable: true),
                    StartTime = table.Column<string>(type: "longtext", nullable: true),
                    EndTime = table.Column<string>(type: "longtext", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: false),
                    EventName = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_time_table", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hall_capacities");

            migrationBuilder.DropTable(
                name: "time_table");
        }
    }
}
