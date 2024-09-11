using Company.Data.Models;
using Company.Service.Interfaces.Dto;
using Data.Models;

namespace Company.Service.Interfaces;

public interface IEmployeeService
{
    EmployeeDto GetById(int? id);
    
    IEnumerable<EmployeeDto> GetAll();
    
    void Add(EmployeeDto employee);
    
    void Update(Employee employee);
    
    void Delete(Employee employee);

    IEnumerable<EmployeeDto> GetEmployeeByName(string name);

}