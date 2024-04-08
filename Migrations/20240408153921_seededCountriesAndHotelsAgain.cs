using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Listings.Migrations
{
    /// <inheritdoc />
    public partial class seededCountriesAndHotelsAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 2, "1 Short Road, Nottingham, UK", 2, "Travel lodge", 6.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
