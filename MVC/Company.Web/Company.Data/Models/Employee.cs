using Microsoft.AspNetCore.Http;

namespace Company.Data.Models;

public class Employee : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Salary { get; set; }
    public DateTime HireDate { get; set; }
    public string ImageUrl { get; set; }
    public DateTime? HiringDate { get; set; }
    public Department? Department { get; set; }
    public int? DepartmentId { get; set; }
    
}