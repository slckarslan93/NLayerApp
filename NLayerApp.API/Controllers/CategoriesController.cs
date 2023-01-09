using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NLayerApp.Core.Services;

namespace NLayerApp.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {
            return CreateActionResult(await categoryService.GetSingleCategoryByIdWithProductAsync(categoryId));
        }
    }
}