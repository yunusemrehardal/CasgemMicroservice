using CasgemMicroservice.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        public Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ResultCategoryDto>>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ResultCategoryDto>> GetByIdCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
