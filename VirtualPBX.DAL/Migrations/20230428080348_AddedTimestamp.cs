using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPBX.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedTimestamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "People",
                type: "bytea",
                rowVersion: true,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "People");
        }
    }
}
