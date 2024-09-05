using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interface;

namespace Company.Repository.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly CompanyDBContext _context;

    public GenericRepository(CompanyDBContext context)
    {
        _context = context;
    }

    public T GetById(int id)
    {
        _context.Set<T>().Find(id);

        return _context.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll() => _context.Set<T>().ToList();


    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);

        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);

        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);

        _context.SaveChanges();
    }
}