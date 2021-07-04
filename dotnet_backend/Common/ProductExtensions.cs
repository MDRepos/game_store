using dotnet_backend.Contracts.V1;
using dotnet_backend.Data;

namespace dotnet_backend.Common
{
    public static class ProductExtensions
    {
        public static ProductEntity ToEntity(this Product domain)
        {
            return new ProductEntity
            {
                Id = domain.Id,
                Name = domain.Name,
                Description = domain.Description,
                Price = domain.Price,
                Year = domain.Year,
                ImageUrl = domain.ImageUrl,
                Category = domain.Category,
            };
        }

        public static ProductViewModel ToViewModel(this Product domain)
        {
            return new ProductViewModel(
            domain.Id,
            domain.Name,
            domain.Description,
            domain.Price,
            domain.Year,
            domain.ImageUrl,
            domain.Category
                );
        }
    }
}