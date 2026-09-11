using ItAssetManagement.Domain.Employees;

namespace ItAssetManagement.Infrastructure.Employees.Persistence.InMemory;

internal class InMemoryEmployeeStore : IEmployeeStore
{
    private readonly List<Employee> _employees = [];

    public bool Add(Employee employee)
    {
        ArgumentNullException.ThrowIfNull(employee);

        _employees.Add(employee);

        return true;
    }

    public IReadOnlyList<Employee> GetAll()
    {
        return _employees
            .OrderBy(x => x.EmployeeName.Value)
            .ToList();
    }
}