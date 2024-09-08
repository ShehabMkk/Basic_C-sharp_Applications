using AutoMapper;
using Company.Data.Models;
using Company.Service.Interfaces.Dto;

namespace Company.Service.Mapping;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
    }
}