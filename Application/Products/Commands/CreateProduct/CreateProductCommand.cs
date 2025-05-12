namespace Application.Products.Commands.CreateProduct;

public record CreateProductCommand(string Name, decimal Price, Guid CategoryId) : IRequest<Guid>;
