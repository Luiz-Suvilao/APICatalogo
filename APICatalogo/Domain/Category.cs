using System.Collections.ObjectModel;

namespace APICatalogo.Domain;

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUri { get; set; }
    public ICollection<Product>? Products { get; set; } = new Collection<Product>();
}