﻿namespace Application.Categories.Commands.CreateCategory;

public record CreateCategoryCommand(string Name) : IRequest<Guid>;
