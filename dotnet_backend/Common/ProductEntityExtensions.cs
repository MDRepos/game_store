using dotnet_backend.Data;

namespace dotnet_backend.Common
{
    public static class ProductEntityExtensions
    {
        public static Product ToDomain(this ProductEntity entity)
        {
            return new Product(
             entity.Name,
             entity.Year,
             entity.Description,
             entity.ImageUrl,
             entity.Name,
             entity.Platform,
             entity.Price,
             entity.Id);
        }
    }
}