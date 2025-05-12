using Application.DTOs;
using Domain.Entities;

namespace Application.Categories.Queries.GetAllCategories;

public record GetAllCategoriesQuery : IRequest<List<CategoryDto>>;
