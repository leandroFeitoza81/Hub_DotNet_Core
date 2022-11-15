namespace DependencyInjection.Example.Models;

public class Repository : IRepostitory
{
    private readonly Dictionary<string, Product> _products;

    public Repository()
    {
        _products = new Dictionary<string, Product>();
        new List<Product>()
        {
            new Product { Name = "Women Shoes", Price = 99M },
            new Product { Name = "Skirts", Price = 29.99M },
            new Product { Name = "Pants", Price = 40.5M }
        }.ForEach(p => AddProduct(p));
    }

    public IEnumerable<Product> Products => _products.Values;
    public Product this[string name] => _products[name];
    public void AddProduct(Product product) => _products[product.Name] = product;
    public void DeleteProduct(Product product) => _products.Remove(product.Name);

}