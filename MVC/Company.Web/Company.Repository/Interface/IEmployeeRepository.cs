using Company.Data.Models;

namespace Company.Repository.Interface;

public interface IEmployeeRepository : IGenericRepository<Employee>
{
    IEnumerable<Employee> GetEmployeeByName(string name);
    IEnumerable<Employee> GetEmployeesByAddress(string address);
}