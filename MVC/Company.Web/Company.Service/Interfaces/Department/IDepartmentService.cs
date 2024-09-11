using Company.Data.Models;
using Company.Service.Interfaces.Dto;
using Data.Models;

namespace Company.Service.Interfaces;

public interface IDepartmentService
{
    DepartmentDto GetById(int? id);
    
    IEnumerable<DepartmentDto> GetAll();
    
    void Add(DepartmentDto department);
    
    void Update(Department department);
    
    void Delete(Department department);

}