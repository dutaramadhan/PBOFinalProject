using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations.DB
{
    /// <inheritdoc />
    public partial class UpdateTaskModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Task",
                newName: "Time");

            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "Task",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Task",
                newName: "Name");
        }
    }
}
