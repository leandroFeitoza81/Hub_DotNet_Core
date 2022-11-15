namespace DependencyInjection.Example.Models;

public interface IRepostitory
{
    IEnumerable<Product> Products { get; }
    Product this[string name] { get; }

    void AddProduct(Product product);
    void DeleteProduct(Product product);
}