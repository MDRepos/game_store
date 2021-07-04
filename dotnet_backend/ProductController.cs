using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using dotnet_backend.Common;
using dotnet_backend.Contracts.V1;

namespace dotnet_backend
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ReadSingle(int id)
        {
            var domainModel = await _service.GetById(id);
            return domainModel == null
                ? NotFound($"Product with id {id} was not found")
                : Ok(domainModel.ToViewModel());
        }

        [HttpGet]
        public async Task<IActionResult> Read()
        {
            var domainModels = await _service.GetAll();
            var viewModels = domainModels.Select(x => x.ToViewModel());
            return Ok(viewModels);
        }

        /*         [HttpPost]
                public async Task<IActionResult> Create([FromBody] ProductCreateModel createModel)
                {
                    var domainModel = createModel.ToDomain();
                    var createdProduct = await _service.CreateNewProduct(domainModel);
                    return createdProduct == null
                        ? BadRequest("Product can not be created, already exists in database")
                        : Ok(createdProduct.ToViewModel());
                }

                [HttpPut]
                public async Task<IActionResult> Update([FromBody] ProductUpdateModel updateModel)
                {
                    var domainModel = updateModel.ToDomain();
                    var updatedProduct = await _service.UpdateProduct(domainModel);
                    return updatedProduct == null
                        ? NotFound("Product can not be updated, because it does not exist in the database")
                        : Ok(updatedProduct.ToViewModel());
                }

                [HttpDelete("{name}")]
                public async Task<IActionResult> Delete(string name)
                {
                    var deletedProduct = await _service.DeleteByName(name);
                    return deletedProduct == null
                        ? NotFound("Product can not be deleted, because it does not exist in the database")
                        : Ok(deletedProduct.ToViewModel());
                } */
    }
}