using Domain.Interfaces;

namespace Application.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;

    public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IProductRepository productRepository)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
    }

    public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(request.Id);
        if (category == null)
            return false;

        var products = await _productRepository.GetAllAsync();
        bool hasProduct = products.Any(p => p.Category_id == request.Id);

        if (hasProduct)
            throw new InvalidOperationException("No se puede eliminar la categoria por que tiene productos!!");
        await _categoryRepository.DeleteAsync(category);
        return true;
        
    }
}