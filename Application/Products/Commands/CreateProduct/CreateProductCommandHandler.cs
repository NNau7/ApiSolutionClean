using Domain.Entities;
using Domain.Interfaces;

namespace Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public CreateProductCommandHandler(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
        if (category == null)
            throw new InvalidOperationException("La categoria no existe");

        var product = new Product
        {
            id = Guid.NewGuid(),
            name = request.Name,
            price = request.Price,
            Category_id = request.CategoryId,
        };
        
        await _productRepository.AddAsync(product);
        return product.id;
    }
}