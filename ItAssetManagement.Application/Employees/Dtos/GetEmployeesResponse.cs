using ItAssetManagement.Domain.Employees;

namespace ItAssetManagement.Application.Employees.Dtos;

public record GetEmployeesResponse(
    bool Success,
    IReadOnlyList<Employee> Employees,
    string? Error);