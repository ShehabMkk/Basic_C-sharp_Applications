using AutoMapper;
using Company.Repository.Interfaces;
using Company.Service.Interfaces.Dto;
using Company.Data.Models;

namespace Company.Service.Interfaces.Services;

public class DepartmentService : IDepartmentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public DepartmentService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public Department GetById(int? id)
    {
        if (id is null)
            return null;
        
        var department = _unitOfWork.DepartmentRepository.GetById(id.Value);
        if (department is null)
            return null;
        
        var mappedDepartment = _mapper.Map<Department>(department);
        return mappedDepartment;
    }

    public IEnumerable<Department> GetAll()
    {
        var departments = _unitOfWork.DepartmentRepository.GetAll();
        var mappedDepartments = _mapper.Map<IEnumerable<Department>>(departments);
        return mappedDepartments;
    }

    public void Add(DepartmentDto departmentDto)
    {
        var mappedDepartment = _mapper.Map<Department>(departmentDto);
        
        _unitOfWork.DepartmentRepository.Add(mappedDepartment);

        _unitOfWork.Complete();
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