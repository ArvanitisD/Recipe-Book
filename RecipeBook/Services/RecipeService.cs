using RecipeBook.Models;

namespace RecipeBook.Services
{
    public class RecipeService
    {
        private readonly List<Recipe> _recipes = new()
        {
            new Recipe
            {
                Id = 1,
                Title = "Spaghetti Carbonara",
                Category = "Italian",
                Description = "A classic Roman pasta dish.",
                ImageUrl = "/images/Carbonara.jpg",
                Instructions = "1. Boil pasta.\n2. Mix eggs and cheese.\n3. Cook pancetta.\n4. Combine everything off heat.",
                Ingredients = new()
                {
                    new Ingredient { Name = "Spaghetti", Quantity = "200", Unit = "g" },
                    new Ingredient { Name = "Eggs", Quantity = "3", Unit = "pcs" },
                    new Ingredient { Name = "Pancetta", Quantity = "100", Unit = "g" },
                    new Ingredient { Name = "Parmesan", Quantity = "50", Unit = "g" },
                    new Ingredient { Name = "Black Pepper", Quantity = "1", Unit = "tsp" }
                }
            },
            new Recipe
            {
                Id = 2,
                Title = "Chicken Curry",
                Category = "Curry",
                Description = "Creamy, spicy, and full of flavor.",
                ImageUrl = "/images/Chicken Curry.jpg",
                Instructions = "1. Sauté onions and garlic.\n2. Add spices and chicken.\n3. Simmer with coconut milk.",
                Ingredients = new()
                {
                    new Ingredient { Name = "Chicken Breast", Quantity = "500", Unit = "g" },
                    new Ingredient { Name = "Coconut Milk", Quantity = "400", Unit = "ml" },
                    new Ingredient { Name = "Curry Powder", Quantity = "2", Unit = "tbsp" },
                    new Ingredient { Name = "Onion", Quantity = "1", Unit = "pcs" },
                    new Ingredient { Name = "Garlic", Quantity = "3", Unit = "cloves" }
                }
            },
            new Recipe
            {
                Id = 3,
                Title = "Beef Stroganoff",
                Category = "Beef",
                Description = "Tender beef in a creamy mushroom sauce.",
                ImageUrl = "/images/Beef Stroganoff.jpg",
                Instructions = "1. Sauté beef strips.\n2. Add mushrooms and onions.\n3. Stir in sour cream and serve over noodles.",
                Ingredients = new()
                {
                    new Ingredient { Name = "Beef Strips", Quantity = "400", Unit = "g" },
                    new Ingredient { Name = "Mushrooms", Quantity = "200", Unit = "g" },
                    new Ingredient { Name = "Sour Cream", Quantity = "150", Unit = "ml" },
                    new Ingredient { Name = "Onion", Quantity = "1", Unit = "pcs" },
                    new Ingredient { Name = "Egg Noodles", Quantity = "250", Unit = "g" }
                }
            }

        };

        public Task<List<Recipe>> GetBestRecipesAsync()
        {
            return Task.FromResult(_recipes);
        }
        public Task<Recipe?> GetByIdAsync(int id)
        {
            var recipe = _recipes.FirstOrDefault(r => r.Id == id);
            return Task.FromResult(recipe);
        }


        public Task SaveRatingAsync(int recipeId, int rating)
        {
            var recipe = _recipes.FirstOrDefault(r => r.Id == recipeId);

            if (recipe is not null)
                recipe.Rating = rating;

            return Task.CompletedTask;
        }

        private int _nextId = 4;

        public Task AddRecipeAsync(Recipe recipe)
        {
            recipe.Id = _nextId++;
            _recipes.Add(recipe);
            return Task.CompletedTask;
        }

    }

}
