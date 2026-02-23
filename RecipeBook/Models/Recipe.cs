namespace RecipeBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public List<Ingredient> Ingredients { get; set; } = new();
        public int Rating { get; set; } = 0;

    }
}
