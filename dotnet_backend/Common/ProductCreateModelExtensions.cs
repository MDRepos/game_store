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
            if (createModel.Category is null) throw new ArgumentNullException(nameof(createModel.Category));
            if (createModel.Platform is null) throw new ArgumentNullException(nameof(createModel.Platform));
            if (createModel.Description is null) throw new ArgumentNullException(nameof(createModel.Description));

            return new Product(
            createModel.Name,
            createModel.Year.Value,
            createModel.Price.Value,
            createModel.Category,
            createModel.Description,
            createModel.Platform,
            createModel.ImageUrl
            );
        }
    }
}