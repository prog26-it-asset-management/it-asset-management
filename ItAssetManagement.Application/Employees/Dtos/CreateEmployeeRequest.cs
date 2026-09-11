namespace ItAssetManagement.Application.Employees.Dtos;

public record CreateEmployeeRequest(
    string EmployeeName,
    string EmailAddress,
    string? PhoneNumber);