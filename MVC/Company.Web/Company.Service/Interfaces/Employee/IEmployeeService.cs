namespace Company.Service.Interfaces.Employee;
using Company.Data.Models;

public interface IEmployeeService
{
    Employee GetById(int? id);
    IEnumerable<Employee> GetAll();
    void Add(Employee employee);
    void Update(Employee employee);
    void Delete(Employee employee);  
}