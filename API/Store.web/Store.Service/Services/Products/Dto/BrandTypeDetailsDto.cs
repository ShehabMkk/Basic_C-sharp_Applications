namespace Store.Service.Services.Products.Dto;

public class BrandTypeDetailsDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}