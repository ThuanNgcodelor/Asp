
namespace AnimeAsp.Models
{
    public class CategoryModel
    {
        public long Id { get; set; }

        public string CategoryName { get; set; }

        public ICollection<ProductModel> Products { get; set; }

        public ICollection<MovieModel> Movies { get; set; }


        public CategoryModel()
        {
            Products = new List<ProductModel>();
            Movies = new List<MovieModel>();
        }

        public CategoryModel(string categoryName, ICollection<ProductModel> products, ICollection<MovieModel> movies)
        {
            CategoryName = categoryName;
            Products = products;
            Movies = movies;
        }
    }
}