using Application.DTOs;

namespace Application.Products.Queries.GetAllProducts;

public record GetAllProductsQuery() : IRequest<List<ProductDto>>;

