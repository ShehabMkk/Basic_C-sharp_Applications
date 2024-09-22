using AutoMapper;
using Company.Repository.Interfaces;
using Company.Service.Helper;
using Company.Service.Interfaces.Dto;
using Company.Data.Models;

namespace Company.Service.Interfaces.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public EmployeeService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public Employee GetById(int? id)
    {
        if (id is null)
            return null;
        
        var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);
        if (employee is null)
            return null;
        
        
        

        Employee employeeDto = _mapper.Map<Employee>(employee);
        
        return employeeDto;
    }

    public IEnumerable<Employee> GetAll()
    {
        var employees = _unitOfWork.EmployeeRepository.GetAll();
        
        IEnumerable<Employee> mappedEmployees = _mapper.Map<IEnumerable<Employee>>(employees);
        return mappedEmployees;
    }

    public void Add(EmployeeDto employeeDto)
    {
        employeeDto.ImageName = DocumentSettings.UploadFile(employeeDto.ImageUrl, "Images");
        
        Employee employee = _mapper.Map<Employee>(employeeDto);

        _unitOfWork.EmployeeRepository.Add(employee);

        _unitOfWork.Complete();
    }
    
    public void Update(Employee employee)
    {
        _unitOfWork.EmployeeRepository.Update(employee);

        _unitOfWork.Complete();
    }

    public void Delete(Employee employee)
    {
        _unitOfWork.EmployeeRepository.Delete(employee);

        _unitOfWork.Complete();
    }

    public IEnumerable<Employee> GetEmployeeByName(string name)
    {
        var employees = _unitOfWork.EmployeeRepository.GetEmployeeByName(name);
        
        IEnumerable<Employee> mappedEmployees = _mapper.Map<IEnumerable<Employee>>(employees);
        return mappedEmployees;
    }
}