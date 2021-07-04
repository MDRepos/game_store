using System;
using dotnet_backend.Contracts.V1;

namespace dotnet_backend.Common
{
    public static class ProductCreateModelExtensions
    {
        public static Product ToDomain(this ProductCreateModel createModel)
        {
            if (createModel.Name is null) throw new ArgumentNullException(nameof(createModel.Name));
            if (createModel.Year is null) throw new ArgumentNullException(nameof(createModel.Year));
            if (createModel.Price is null) throw new ArgumentNullException(nameof(createModel.Price));
            if (createModel.ImageUrl is null) throw new ArgumentNullException(nameof(createModel.ImageUrl));
            if (createModel.Description is null) throw new ArgumentNullException(nameof(createModel.Description));

            return new Product(
            createModel.Id.Value,
            createModel.Name,
            createModel.Description,
            createModel.Price.Value,
            createModel.Year.Value,
            createModel.ImageUrl,
            createModel.Category.Value
            );
        }
    }
}