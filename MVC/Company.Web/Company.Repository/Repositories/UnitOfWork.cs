using Company.Repository.Interfaces;
using Company.Data.Contexts;
using Company.Repository.Interface;

namespace Company.Repository.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly CompanyDBContext _context;
    public UnitOfWork(CompanyDBContext context)
    {
        _context = context;
        DepartmentRepository = new DepartmentRepository(context);
        EmployeeRepository = new EmployeeRepository(context);
    }
    public IDepartmentRepository DepartmentRepository { get; set; }
    public IEmployeeRepository EmployeeRepository { get; set; }
    public int Complete() => _context.SaveChanges();
}