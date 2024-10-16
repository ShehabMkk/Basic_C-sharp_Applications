using AutoMapper;
using Store.Data.Entities;
using Store.Repository.Interfaces;
using Store.Repository.Specification.ProductSpecs;
using Store.Service.Helper;
using Store.Service.Services.Products.Dto;

namespace Store.Service.Services.Products;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public ProductService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllBrandsAsync()
    {
        var brands = await _unitOfWork.Repository<ProductBrand, int>().GetAllAsNoTrackingAsync();
        var mappedBrands = _mapper.Map<IReadOnlyList<BrandTypeDetailsDto>>(brands);

        return mappedBrands;
    }
    
    public async Task<PaginatedResultDto<ProductDetailsDto>> GetAllProductsAsync(ProductSpecification input)
    {
        var specs = new ProductWithSpecifications(input);
        var products = await _unitOfWork.Repository<Product, int>().GetAllWithSpecificationAsync(specs);
        var countSpecs = new ProductWithCountSpecification(input);
        var count = await _unitOfWork.Repository<Product, int>().GetCoutSpecificationAsync(countSpecs);
        var mappedProducts = _mapper.Map<IReadOnlyList<ProductDetailsDto>>(products);

        return new PaginatedResultDto<ProductDetailsDto>(input.PageSize , input.PageIndex, count, mappedProducts);
    }
    
    public async Task<IReadOnlyList<ProductDetailsDto>> GetAllProductsAsync()
    {
        var products = await _unitOfWork.Repository<Product, int>().GetAllAsNoTrackingAsync();
        var mappedProducts = _mapper.Map<IReadOnlyList<ProductDetailsDto>>(products);

        return mappedProducts;
    }
    
    public async Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllTypesAsync()
    {
        var types = await _unitOfWork.Repository<ProductType, int>().GetAllAsNoTrackingAsync();
        var mappedTypes = _mapper.Map<IReadOnlyList<BrandTypeDetailsDto>>(types);

        return mappedTypes;
    }
    
    public async Task<ProductDetailsDto> GetProductByIdAsync(int? productId)
    {
        if(productId is null)
            throw new Exception("Id is null");
        
        var product = await _unitOfWork.Repository<Product, int>().GetByIdAsync(productId.Value);
        if(product is null)
            throw new Exception("Product Not Found");
        
        var mappedProduct = _mapper.Map<ProductDetailsDto>(product);
        
        return mappedProduct;
    }
}