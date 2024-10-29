using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixComputedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullLicensePlate",
                table: "LicensePlates",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[CityCode] +' ' + [ProvienceCode] + ' ' +[RegistrationYear]+CONVERT (nvarchar(50),[Id])",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[CityCode] +' ' + [ProvienceCode] + ' ' +[RegistrationYear]+[Id]",
                oldStored: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullLicensePlate",
                table: "LicensePlates",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[CityCode] +' ' + [ProvienceCode] + ' ' +[RegistrationYear]+[Id]",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[CityCode] +' ' + [ProvienceCode] + ' ' +[RegistrationYear]+CONVERT (nvarchar(50),[Id])",
                oldStored: true);
        }
    }
}
