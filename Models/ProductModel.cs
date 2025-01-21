
namespace AnimeAsp.Models;

public class ProductModel
{
    public long Id { get; set; }
    public string productName { get; set; }
    public string productDescription { get; set; }
    public string productImage { get; set; }
    public decimal productPrice { get; set; }
    public int productQuantity { get; set; }
    public ICollection<CategoryModel> categories { get; set; }

    public ProductModel()
    {
        categories = new List<CategoryModel>();
    }

    public ProductModel( string productName, string productDescription, string productImage,
        decimal productPrice, int productQuantity,
        ICollection<CategoryModel> categories)
    {
        this.productName = productName;
        this.productDescription = productDescription;
        this.productImage = productImage;
        this.productPrice = productPrice;
        this.productQuantity = productQuantity;
        this.categories = new List<CategoryModel>();
    }
}