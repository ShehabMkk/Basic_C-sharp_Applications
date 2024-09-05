using Company.Repository.Interface;
using Company.Repository.Interfaces;
using Company.Service.Interfaces.Department;
namespace Company.Service.Services.Department;
using Company.Data.Models;

public class DepartmentService : IDepartmentService
{

    private readonly IUnitOfWork _unitOfWork;
    public DepartmentService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Department> GetAll()
    {
        return _unitOfWork.DepartmentRepository.GetAll();
    }

    public Department GetById(int? id)
    {
        if (id is null)
            return null;
        
        var department = _unitOfWork.DepartmentRepository.GetById(id.Value);
        if (department is null)
            return null;
        
        return department;
    }

    public void Add(Department department)
    {
        var mappedDepartment = new Department
        {
            Name = department.Name,
            Code = department.Code,
            IsCreated = DateTime.Now
        };
        _unitOfWork.DepartmentRepository.Add(mappedDepartment);

    }

    public void Update(Department department)
    {
        _unitOfWork.DepartmentRepository.Update(department);

        _unitOfWork.Complete();
    }

    public void Delete(Department department)
    {
        _unitOfWork.DepartmentRepository.Delete(department);

        _unitOfWork.Complete();
    }

}