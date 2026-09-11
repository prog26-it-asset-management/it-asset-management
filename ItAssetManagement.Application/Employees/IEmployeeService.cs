using ItAssetManagement.Application.Employees.Dtos;

namespace ItAssetManagement.Application.Employees;

public interface IEmployeeService
{
    CreateEmployeeResponse CreateEmployee(CreateEmployeeRequest request);
    GetEmployeesResponse GetAllEmployees();
}