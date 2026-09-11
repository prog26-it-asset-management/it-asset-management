namespace ItAssetManagement.Domain.Employees;

public interface IEmployeeStore
{
    bool Add(Employee employee);
    IReadOnlyList<Employee> GetAll();
}