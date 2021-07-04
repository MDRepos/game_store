using dotnet_backend.Data;

namespace dotnet_backend.Common
{
    public static class ProductEntityExtensions
    {
        public static Product ToDomain(this ProductEntity entity)
        {
            return new Product(
            entity.Id,
            entity.Name,
            entity.Description,
            entity.Price,
            entity.Year,
            entity.ImageUrl,
            entity.Category
             );
        }
    }
}