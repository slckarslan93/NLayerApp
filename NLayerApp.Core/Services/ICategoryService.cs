using NLayerApp.Core.DTOs;
using NLayerApp.Core.Model;

namespace NLayerApp.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductAsync(int categoryId);
    }
}