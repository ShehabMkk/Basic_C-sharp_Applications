using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interface;
using Company.Repository.Interfaces;
using Data.Models.Contexts;
using Data.Models;

namespace Company.Repository.Repositories;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private readonly CompanyDBContext _context;
    public EmployeeRepository(CompanyDBContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Employee> GetEmployeeByName(string name)
        => _context.Employees.Where(x => x.Name.Trim().ToLower().Contains(name.Trim().ToLower()) 
            || x.Email.Trim().ToLower().Contains(name.Trim().ToLower())
            || x.Phone.Trim().ToLower().Contains(name.Trim().ToLower())
            ).ToList();

    public IEnumerable<Employee> GetEmployeesByAddress(string address)
    {
        throw new NotImplementedException();
    }
}