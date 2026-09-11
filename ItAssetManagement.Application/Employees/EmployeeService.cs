using ItAssetManagement.Application.Employees.Dtos;
using ItAssetManagement.Domain.Employees;
using ItAssetManagement.Domain.ValueObjects;
using System.Xml;

namespace ItAssetManagement.Application.Employees;

internal class EmployeeService(IEmployeeStore employeeStore) : IEmployeeService
{
    public CreateEmployeeResponse CreateEmployee(CreateEmployeeRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        var id = new UniqueId(Guid.NewGuid());
        var employeeName = new EmployeeName(request.EmployeeName);
        var emailAddress = new EmailAddress(request.EmailAddress);

        var phoneNumber = string.IsNullOrWhiteSpace(request.PhoneNumber)
            ? null
            : new PhoneNumber(request.PhoneNumber);

        var employee = new Employee(
            id,
            employeeName,
            emailAddress,
            phoneNumber);

        var added = employeeStore.Add(employee);

        return added
            ? new CreateEmployeeResponse(true, employee, null)
            : new CreateEmployeeResponse(false, null, "Unable to save employee.");
    }

    public GetEmployeesResponse GetAllEmployees()
    {
        var employees = employeeStore.GetAll();

        var response = new GetEmployeesResponse(true, employees, null);

        return response;
    }
}