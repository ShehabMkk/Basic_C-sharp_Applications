using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interface;

namespace Company.Repository.Repositories;

public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
    private readonly CompanyDBContext _context;

    public DepartmentRepository(CompanyDBContext context) : base( context )
    {
        _context = context;
    }
}