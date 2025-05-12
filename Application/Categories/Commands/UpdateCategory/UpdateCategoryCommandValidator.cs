namespace Application.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCategoryCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre no puede estar vacio")
            .MaximumLength(100).WithMessage("El nombre no puede ser mayor a 100 caracteres");
    }
}