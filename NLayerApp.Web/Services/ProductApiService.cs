using NLayerApp.Core.DTOs;

namespace NLayerApp.Web.Services
{
    public class ProductApiService
    {
        private readonly HttpClient _httpClient;

        public ProductApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductWithCategoryDto>> GetProductsWithCategoryAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductWithCategoryDto>>>("products/GetProductsWithCategory");
            return response.Data;
        }

        public async Task<ProductDto> SaveAsync(ProductDto newProduct)
        {
            var response = await _httpClient.PostAsJsonAsync("products", newProduct);
            if (!response.IsSuccessStatusCode) return null;

            var responseBoody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProductDto>>();
            return responseBoody.Data;
        }

        public async Task<bool> UpdateAsync(ProductDto newProduct)
        {
            var response = await _httpClient.PutAsJsonAsync("products", newProduct);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"products/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<ProductDto>>($"products/{id}");
            return response.Data;
        }
    }
}