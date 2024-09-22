using Store.Service.Services.Products.Dto;

namespace Store.Service.Services.Products;

public interface IProductService
{
    Task<ProductDetailsDto> GetProductByIdAsync(int? productId);
    Task<IReadOnlyList<ProductDetailsDto>> GetAllProductsAsync();
    Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllBrandsAsync();
    Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllTypesAsync();
}