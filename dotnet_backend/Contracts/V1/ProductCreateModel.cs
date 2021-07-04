
using FluentValidation;

namespace dotnet_backend.Contracts.V1
{
    public class ProductCreateModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public int? Year { get; set; }
        public string? ImageUrl { get; set; }
        public string[]? Platform { get; set; }
        public object? Category { get; set; }

    }

    public class ProductCreateModelValidator : AbstractValidator<ProductCreateModel>
    {
        public ProductCreateModelValidator()
        {
            RuleFor(x => x.Name)
                .Length(0, 14)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Price)
                .InclusiveBetween(0, 100)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Year)
                .InclusiveBetween(1990, 2050)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Category)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Platform)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.ImageUrl)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty();
        }
    }
}