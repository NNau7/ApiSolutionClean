namespace Domain.Entities;

public class Category
{
    public Guid category_id { get; set; }
    public string category_name { get; set; }
    
    public ICollection<Product> Products { get; set; } = new List<Product>();
    
}