using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Comp229_301052117_Assign3.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    RecipesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientID);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(nullable: false),
                    Servings = table.Column<string>(nullable: false),
                    DishName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Instructions = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    ingredients1 = table.Column<string>(nullable: true),
                    ingredients2 = table.Column<string>(nullable: true),
                    ingredients3 = table.Column<string>(nullable: true),
                    review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipesID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
