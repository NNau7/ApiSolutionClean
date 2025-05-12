using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Category, CategoryDto>();
    }
}