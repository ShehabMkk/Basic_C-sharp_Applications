using Microsoft.AspNetCore.Http;

namespace Company.Service.Interfaces.Dto;

public class EmployeeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime HireDate { get; set; }
    public IFormFile? ImageUrl { get; set; }
    public string? ImageName { get; set; }
    public DepartmentDto? Department { get; set; }
    public int? DepartmentId { get; set; }
    public DateTime IsCreated { get; set; }

}