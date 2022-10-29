using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace WebRecipe.Models;

internal class SeedRecipe : IEntityTypeConfiguration<Recipe> {
    public void Configure(EntityTypeBuilder<Recipe> builder) {
        builder.HasData(
            new Recipe { RecipeID = 1, Name = "Fruit Salad", 
            Description = "The perfect fruit salad for a backyard bbq or any occasion. There are never leftovers! This is one of my favorite fruit salad recipes, as I think the sauce really makes it. This salad is tastier the longer you can let it soak in its juices. I prefer 3 to 4 hours in the refrigerator before I serve it. Enjoy.", 
            Steps = "Bring orange juice, lemon juice, brown sugar, orange zest, and lemon zest to a boil in a saucepan over medium-high heat. Reduce heat to medium-low, and simmer until slightly thickened, about 5 minutes. Remove from heat, and stir in vanilla extract. Set aside to cool.|Layer the fruit in a large, clear glass bowl in this order: pineapple, strawberries, kiwi fruit, bananas, oranges, grapes, and blueberries. Pour the cooled sauce over the fruit. Cover and refrigerate for 3 to 4 hours before serving.", 
            CategoryID = "favt", Rating = 4, FoodImage = "fruinsal", PreparationTime = 45},
            new Recipe { RecipeID = 2, Name = "Chocolate Eclair Dessert", 
            Description = "This is a no-bake pudding dessert that's so quick and easy to make--everyone loves it. I always keep the ingredients on hand in case I need a quick dessert. It's best if it sits overnight before serving.", 
            Steps = "Line the bottom of a 9x13-inch pan with graham crackers.|In a large bowl, combine pudding mix and milk; stir well. Mix whipped topping into pudding mixture. Spread half of mixture over graham cracker layer. Top with another layer of graham crackers and the remaining pudding.|Top all with a final layer of graham crackers and frost with chocolate frosting. Refrigerate at least two hours before serving to allow the graham crackers to soften.",
            CategoryID = "dssr", Rating = 5, FoodImage = "chocdess", PreparationTime = 90},
            new Recipe { RecipeID = 3, Name = "Zucchini Banana Multi-Grain Bread", 
            Description = "Here's a delicious zucchini bread with just the right touch of whole grains added. Perfect with walnuts or even chopped pecans.", 
            Steps = "Place flour, cranberries, yogurt, water, honey, butter, yeast, salt, and orange oil in the pan of a bread machine in the order recommended by the manufacturer. Select 'light crust' setting; press Start.",
            CategoryID = "grns", Rating = 4, FoodImage = "brgrns", PreparationTime = 20},
            new Recipe { RecipeID = 4, Name = "Lasagna", 
            Description = "It takes a little work, but it is worth it.", 
            Steps = "In a Dutch oven, cook sausage, ground beef, onion, and garlic over medium heat until well browned. Stir in crushed tomatoes, tomato paste, tomato sauce, and water. Season with sugar, basil, fennel seeds, Italian seasoning, 1 teaspoon salt, pepper, and 2 tablespoons parsley. Simmer, covered, for about 1 1/2 hours, stirring occasionally.|Bring a large pot of lightly salted water to a boil. Cook lasagna noodles in boiling water for 8 to 10 minutes. Drain noodles, and rinse with cold water. In a mixing bowl, combine ricotta cheese with egg, remaining parsley, and 1/2 teaspoon salt.|Preheat oven to 375 degrees F (190 degrees C).|To assemble, spread 1 1/2 cups of meat sauce in the bottom of a 9x13-inch baking dish. Arrange 6 noodles lengthwise over meat sauce. Spread with one half of the ricotta cheese mixture. Top with a third of mozzarella cheese slices. Spoon 1 1/2 cups meat sauce over mozzarella, and sprinkle with 1/4 cup Parmesan cheese. Repeat layers, and top with remaining mozzarella and Parmesan cheese. Cover with foil: to prevent sticking, either spray foil with cooking spray, or make sure the foil does not touch the cheese.|Bake in preheated oven for 25 minutes. Remove foil, and bake an additional 25 minutes. Cool for 15 minutes before serving.",
            CategoryID = "prtn", Rating = 5, FoodImage = "lasagimg", PreparationTime = 180},
            new Recipe { RecipeID = 5, Name = "Hummus Pizza", 
            Description = "This pizza uses hummus instead of the usual red sauce—a unique and healthy pizza for those bored with the traditional. Top with your favorite veggies and cheese.", 
            Steps = "Preheat the oven to 475 degrees C (220 degrees C).|Roll out pizza crust and place on a pizza pan or baking sheet. Spread a thin layer of hummus over the crust. Arrange sliced peppers and broccoli over the hummus, and top with shredded cheese.|Bake in the preheated oven until the crust is golden brown and cheese is melted in the center, 10 to 15 minutes. Slice and serve.",
            CategoryID = "srcy", Rating = 4, FoodImage = "vegpzz", PreparationTime = 60}
        );
    }

    /*
   "srcy", "favt", "dssr", "prtn", "grns"
      public int RecipeID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Steps { get; set; }

    public string CategoryID { get; set; }
    public Category Category { get; set; }
    */

}