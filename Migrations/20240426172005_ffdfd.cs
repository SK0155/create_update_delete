using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.Migrations
{
    /// <inheritdoc />
    public partial class ffdfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("Interest", "Students", "Hobbies");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
