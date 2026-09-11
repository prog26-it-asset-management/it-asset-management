using ItAssetManagement.Domain.Employees;

namespace ItAssetManagement.Application.Employees.Dtos;

public record CreateEmployeeResponse(
    bool Success,
    Employee? Employee,
    string? Error);