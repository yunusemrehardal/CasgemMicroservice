using CasgemMicroservice.Services.Catalog.Dtos.ProductDtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public Task<Response<NoContent>> CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ResultProductDto>>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ResultProductDto>> GetByIdProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
