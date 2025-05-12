namespace Domain.Entities;

public class Product
{
    public Guid id { get; set; }
    public string name { get; set; }
    public int stock { get; set; }
    public decimal price { get; set; }
    
    public Guid Category_id { get; set; }
    public  Category Category { get; set; }
}