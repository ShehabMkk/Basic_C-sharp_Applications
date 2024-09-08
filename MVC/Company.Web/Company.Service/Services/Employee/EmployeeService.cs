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
    public EmployeeDto GetById(int? id)
    {
        if (id is null)
            return null;
        
        var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);
        if (employee is null)
            return null;
        
        
        

        EmployeeDto employeeDto = _mapper.Map<EmployeeDto>(employee);
        
        return employeeDto;
    }

    public IEnumerable<EmployeeDto> GetAll()
    {
        var employees = _unitOfWork.EmployeeRepository.GetAll();
        
        IEnumerable<EmployeeDto> mappedEmployees = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        return mappedEmployees;
    }

    public void Add(EmployeeDto employeeDto)
    {
        employeeDto.ImageName = DocumentSettings.UploadFile(employeeDto.ImageUrl, "Images");
        
        Employee employee = _mapper.Map<Employee>(employeeDto);

        _unitOfWork.EmployeeRepository.Add(employee);

        _unitOfWork.Complete();
    }

    public void Update(EmployeeDto employee)
    {
        // _unitOfWork.EmployeeRepository.Update(employee);
        _unitOfWork.Complete();
    }

    public void Delete(EmployeeDto employeeDto)
    {
        Employee employee = _mapper.Map<Employee>(employeeDto);
        _unitOfWork.EmployeeRepository.Delete(employee);

        _unitOfWork.Complete();
    }

    public IEnumerable<EmployeeDto> GetEmployeeByName(string name)
    {
        var employees = _unitOfWork.EmployeeRepository.GetEmployeeByName(name);
        
        IEnumerable<EmployeeDto> mappedEmployees = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        return mappedEmployees;
    }
}