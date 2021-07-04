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
                Name = domain.Name,
                Price = domain.Price,
                Description = domain.Description,
                Year = domain.Year,
                ImageUrl = domain.ImageUrl,
                Category = domain.Category,
                Platform = domain.Platform,
                Id = domain.Id
            };
        }

        public static ProductViewModel ToViewModel(this Product domain)
        {
            return new ProductViewModel(
                domain.Name,
                domain.Description,
                domain.Category,
                domain.ImageUrl,
                domain.Platform,
                domain.Price,
                domain.Year,
                domain.Id
                );
        }
    }
}