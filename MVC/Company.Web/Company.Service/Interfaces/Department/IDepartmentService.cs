using Company.Data.Models;
using Company.Service.Interfaces.Dto;

using Data.Models;

namespace Company.Service.Interfaces;

public interface IDepartmentService
{
    Department GetById(int? id);
    IEnumerable<Department> GetAll();
   // IEnumerable<DepartmentDto> GetAll();
    

    void Add(DepartmentDto department);
    
    void Update(Department department);
    
    void Delete(Department department);

}