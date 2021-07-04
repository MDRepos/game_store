
using System.Linq;
using System.Collections.Generic;
using dotnet_backend.Data;
using System.Threading.Tasks;
using dotnet_backend.Common;

namespace dotnet_backend
{
    public class ProductService
    {
        private readonly ProductDbContext _db;
        private readonly IDateTimeProvider _dateTimeProvider;

        public ProductService(ProductDbContext dbContext, IDateTimeProvider dateTimeProvider)
        {
            _db = dbContext;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<Product?> GetById(int id)
        {
            var entity = _db.ProductSet
                .Where(x => x.id == id)
                .ToList()
                .FirstOrDefault();

            var domainModel = entity?.ToDomain();
            return domainModel;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return _db.ProductSet.Select(x => x.ToDomain()).ToList();
        }

        /*         public async Task<Product?> CreateNewProduct(Product Product)
                {
                    var ProductAlreadyExists = await GetByName(Product.Name) != null;

                    if (ProductAlreadyExists)
                    {
                        return null;
                    }

                    var newProduct = Product.ToEntity();
                    newProduct.CreatedDateTime = _dateTimeProvider.Now();
                    newProduct.ModifiedDateTime = _dateTimeProvider.Now();

                    _db.ProductSet.Add(newProduct);
                    await _db.SaveChangesAsync();
                    //_people.Add(Product);
                    return Product;
                }

                public async Task<Product?> UpdateProduct(Product Product)
                {
                    var ProductAlreadyExists = await GetByName(Product.Name) != null;

                    if (!ProductAlreadyExists)
                    {
                        return null;
                    }

                    var entity = _db.ProductSet.FirstOrDefault(x => x.Name.ToLower() == Product.Name.ToLower());

                    entity.Name = Product.Name;
                    entity.Age = Product.Age;
                    entity.ModifiedDateTime = _dateTimeProvider.Now();

                    _db.ProductSet.Update(entity);
                    await _db.SaveChangesAsync();
                    // for(int x = 0; x < _people.Count; x ++)
                    // {
                    //     var element = _people[x];
                    //     if(element.Name == Product.Name)
                    //     {
                    //         _people[x] = Product;
                    //     }
                    // }


                    return Product;
                }

                public async Task<Product?> DeleteByName(string name)
                {
                    var ProductExists = await GetByName(name) != null;

                    if (!ProductExists)
                    {
                        return null;
                    }

                    var entity = _db.ProductSet.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
                    _db.ProductSet.Remove(entity);
                    await _db.SaveChangesAsync();

                    // var Product = _people
                    // .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

                    // //remove Product from people list
                    // _people.Remove(Product);
                    var domainModel = entity.ToDomain();
                    return domainModel;
                } */
    }
}