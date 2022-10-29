using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebRecipe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Steps = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    PreparationTime = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    FoodImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeID);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[,]
                {
                    { "dssr", "Their presence on the menu makes us feel satisfied after a meal, and compensates for low blood sugar. The desire to improve your mood by ingesting sugar can also be a factor. Sweet snacks increase our production of the so-called hormone of happiness. Your habits also play an important role.", "Dessert" },
                    { "favt", "A diet rich in vegetables and fruits can lower blood pressure, reduce the risk of heart disease and stroke, prevent some types of cancer, lower risk of eye and digestive problems, and have a positive effect upon blood sugar, which can help keep appetite in check.", "Fruit And Vegetables" },
                    { "grns", "Grains are important sources of many nutrients, including fiber, B vitamins (thiamin, riboflavin, niacin and folate) and minerals (iron, magnesium and selenium). People who eat whole grains as part of a healthy diet have a reduced risk of some chronic diseases.", "Grains" },
                    { "prtn", "You need protein in your diet to help your body repair cells and make new ones. Protein is also important for growth and development in children, teens, and pregnant women.", "Protein" },
                    { "srcy", "Starchy foods are a good source of energy and the main source of a range of nutrients in our diet. As well as starch, they contain fibre, calcium, iron and B vitamins. Some people think starchy foods are fattening, but gram for gram they contain fewer than half the calories of fat.", "Starchy" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeID", "CategoryID", "Description", "FoodImage", "Name", "PreparationTime", "Rating", "Steps" },
                values: new object[,]
                {
                    { 1, "favt", "The perfect fruit salad for a backyard bbq or any occasion. There are never leftovers! This is one of my favorite fruit salad recipes, as I think the sauce really makes it. This salad is tastier the longer you can let it soak in its juices. I prefer 3 to 4 hours in the refrigerator before I serve it. Enjoy.", "fruinsal", "Fruit Salad", 45, 4, "Bring orange juice, lemon juice, brown sugar, orange zest, and lemon zest to a boil in a saucepan over medium-high heat. Reduce heat to medium-low, and simmer until slightly thickened, about 5 minutes. Remove from heat, and stir in vanilla extract. Set aside to cool.|Layer the fruit in a large, clear glass bowl in this order: pineapple, strawberries, kiwi fruit, bananas, oranges, grapes, and blueberries. Pour the cooled sauce over the fruit. Cover and refrigerate for 3 to 4 hours before serving." },
                    { 2, "dssr", "This is a no-bake pudding dessert that's so quick and easy to make--everyone loves it. I always keep the ingredients on hand in case I need a quick dessert. It's best if it sits overnight before serving.", "chocdess", "Chocolate Eclair Dessert", 90, 5, "Line the bottom of a 9x13-inch pan with graham crackers.|In a large bowl, combine pudding mix and milk; stir well. Mix whipped topping into pudding mixture. Spread half of mixture over graham cracker layer. Top with another layer of graham crackers and the remaining pudding.|Top all with a final layer of graham crackers and frost with chocolate frosting. Refrigerate at least two hours before serving to allow the graham crackers to soften." },
                    { 3, "grns", "Here's a delicious zucchini bread with just the right touch of whole grains added. Perfect with walnuts or even chopped pecans.", "brgrns", "Zucchini Banana Multi-Grain Bread", 20, 4, "Place flour, cranberries, yogurt, water, honey, butter, yeast, salt, and orange oil in the pan of a bread machine in the order recommended by the manufacturer. Select 'light crust' setting; press Start." },
                    { 4, "prtn", "It takes a little work, but it is worth it.", "lasagimg", "Lasagna", 180, 5, "In a Dutch oven, cook sausage, ground beef, onion, and garlic over medium heat until well browned. Stir in crushed tomatoes, tomato paste, tomato sauce, and water. Season with sugar, basil, fennel seeds, Italian seasoning, 1 teaspoon salt, pepper, and 2 tablespoons parsley. Simmer, covered, for about 1 1/2 hours, stirring occasionally.|Bring a large pot of lightly salted water to a boil. Cook lasagna noodles in boiling water for 8 to 10 minutes. Drain noodles, and rinse with cold water. In a mixing bowl, combine ricotta cheese with egg, remaining parsley, and 1/2 teaspoon salt.|Preheat oven to 375 degrees F (190 degrees C).|To assemble, spread 1 1/2 cups of meat sauce in the bottom of a 9x13-inch baking dish. Arrange 6 noodles lengthwise over meat sauce. Spread with one half of the ricotta cheese mixture. Top with a third of mozzarella cheese slices. Spoon 1 1/2 cups meat sauce over mozzarella, and sprinkle with 1/4 cup Parmesan cheese. Repeat layers, and top with remaining mozzarella and Parmesan cheese. Cover with foil: to prevent sticking, either spray foil with cooking spray, or make sure the foil does not touch the cheese.|Bake in preheated oven for 25 minutes. Remove foil, and bake an additional 25 minutes. Cool for 15 minutes before serving." },
                    { 5, "srcy", "This pizza uses hummus instead of the usual red sauce—a unique and healthy pizza for those bored with the traditional. Top with your favorite veggies and cheese.", "vegpzz", "Hummus Pizza", 60, 4, "Preheat the oven to 475 degrees C (220 degrees C).|Roll out pizza crust and place on a pizza pan or baking sheet. Spread a thin layer of hummus over the crust. Arrange sliced peppers and broccoli over the hummus, and top with shredded cheese.|Bake in the preheated oven until the crust is golden brown and cheese is melted in the center, 10 to 15 minutes. Slice and serve." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryID",
                table: "Recipes",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
