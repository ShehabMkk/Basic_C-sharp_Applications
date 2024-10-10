using Store.Repository.Specification.ProductSpecs;
using Store.Service.Helper;
using Store.Service.Services.Products.Dto;

namespace Store.Service.Services.Products;

public interface IProductService
{
    Task<ProductDetailsDto> GetProductByIdAsync(int? productId);
    Task<PaginatedResultDto<ProductDetailsDto>> GetAllProductsAsync(ProductSpecification specs);
    Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllBrandsAsync();
    Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllTypesAsync();
}