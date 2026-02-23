using System.ComponentModel.DataAnnotations;
using RecipeBook.Models;

namespace RecipeBook.Models
{
    public class RecipeFormModel
    {
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title can't exceed 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description can't exceed 500 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Instructions are required.")]
        public string Instructions { get; set; } = string.Empty;

        public List<Ingredient> Ingredients { get; set; } = new();
    }
}