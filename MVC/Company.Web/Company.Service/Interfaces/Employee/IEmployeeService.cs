using Company.Data.Models;
using Company.Service.Interfaces.Dto;
using Data.Models;

namespace Company.Service.Interfaces;

public interface IEmployeeService
{
    Employee GetById(int? id);
    
    IEnumerable<Employee> GetAll();
    
    void Add(EmployeeDto employee);
    
    void Update(Employee employee);
    
    void Delete(Employee employee);

    IEnumerable<Employee> GetEmployeeByName(string name);

}