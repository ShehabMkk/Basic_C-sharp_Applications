using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interface;

namespace Company.Repository.Repositories;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private readonly CompanyDBContext _context;

    public EmployeeRepository(CompanyDBContext context) : base( context )
    {
        _context = context;
    }
    
}