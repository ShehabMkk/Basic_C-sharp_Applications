using Company.Repository.Interface;
using Company.Repository.Interfaces;
using Company.Service.Interfaces.Employee;
namespace Company.Service.Services.Employee;
using Company.Data.Models;

public class EmployeeService : IEmployeeService
{

    private readonly IUnitOfWork _unitOfWork;
    public EmployeeService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Employee> GetAll()
    {
        return _unitOfWork.EmployeeRepository.GetAll();
    }

    public Employee GetById(int? id)
    {
        if (id is null)
            return null;
        
        var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);
        if (employee is null)
            return null;
        
        return employee;
    }

    public void Add(Employee employee)
    {
        var mappedEmployee = new Employee
        {
            Name = employee.Name,
            Age = employee.Age,
            Address = employee.Address,
            Email = employee.Email,
            Phone = employee.Phone,
            Salary = employee.Salary,
            ImageUrl = employee.ImageUrl,
            DepartmentId = employee.DepartmentId,
            IsCreated = DateTime.Now
        };
        _unitOfWork.EmployeeRepository.Add(mappedEmployee);

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

}