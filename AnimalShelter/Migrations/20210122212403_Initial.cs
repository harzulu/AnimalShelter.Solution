using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Breed", "Name" },
                values: new object[,]
                {
                    { 1, "Short Hair", "Baby Girl" },
                    { 2, "Short Hair", "Inky" },
                    { 3, "Siamese", "Marley" },
                    { 4, "Short Hair", "Michael" },
                    { 5, "Short Hair", "Paprika" },
                    { 6, "Long Hair", "Poe" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Breed", "Name" },
                values: new object[,]
                {
                    { 1, "Pit Bull", "Uma" },
                    { 2, "Australian Cattledog", "Abner" },
                    { 3, "Lab Mix", "Jackson" },
                    { 4, "Australian Cattledog", "Aden" },
                    { 5, "Lab Mix", "Meeks" },
                    { 6, "Retriever", "Brett" },
                    { 7, "Pit Bull", "Parker" },
                    { 8, "Chihuahua", "Miss Precious" },
                    { 9, "Pit Bull", "Chickie" },
                    { 10, "German Sheppard", "Jasmine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
