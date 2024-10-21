using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductDetailDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDto>> GettAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryAsync();
        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryByCatetegoryIdAsync(string CategoryId);
    }
}
