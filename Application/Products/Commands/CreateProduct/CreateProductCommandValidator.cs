namespace Application.Products.Commands.CreateProduct;

public class CreateProductCommandValidator :  AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre no puede estar vacio");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("El precio debe ser mayor a 0");
        RuleFor(x => x.CategoryId).NotEmpty().WithMessage("La categoria es obligatoria");
    }
}