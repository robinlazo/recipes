using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace WebRecipe.Models;

internal class SeedCategory : IEntityTypeConfiguration<Category> {
    public void Configure(EntityTypeBuilder<Category> builder) {
        builder.HasData(
            new Category { CategoryID = "srcy", Name = "Starchy", 
            Description = "Starchy foods are a good source of energy and the main source of a range of nutrients in our diet. As well as starch, they contain fibre, calcium, iron and B vitamins. Some people think starchy foods are fattening, but gram for gram they contain fewer than half the calories of fat." },
            new Category { CategoryID = "favt", Name = "Fruit And Vegetables", 
            Description = "A diet rich in vegetables and fruits can lower blood pressure, reduce the risk of heart disease and stroke, prevent some types of cancer, lower risk of eye and digestive problems, and have a positive effect upon blood sugar, which can help keep appetite in check." },
            new Category { CategoryID = "dssr", Name = "Dessert", 
            Description = "Their presence on the menu makes us feel satisfied after a meal, and compensates for low blood sugar. The desire to improve your mood by ingesting sugar can also be a factor. Sweet snacks increase our production of the so-called hormone of happiness. Your habits also play an important role." },
            new Category { CategoryID = "prtn", Name = "Protein", 
            Description = "You need protein in your diet to help your body repair cells and make new ones. Protein is also important for growth and development in children, teens, and pregnant women." },
            new Category { CategoryID = "grns", Name = "Grains", 
            Description = "Grains are important sources of many nutrients, including fiber, B vitamins (thiamin, riboflavin, niacin and folate) and minerals (iron, magnesium and selenium). People who eat whole grains as part of a healthy diet have a reduced risk of some chronic diseases." }
        );
    }
}