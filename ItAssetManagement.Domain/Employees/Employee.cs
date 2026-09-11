using ItAssetManagement.Domain.ValueObjects;
using System.Xml;

namespace ItAssetManagement.Domain.Employees;

public class Employee(
    UniqueId employeeId,
    EmployeeName employeeName,
    EmailAddress emailAddress,
    PhoneNumber? phoneNumber = null)
{
    public UniqueId EmployeeId { get; } = employeeId;
    public EmployeeName EmployeeName { get; private set; } = employeeName;
    public EmailAddress EmailAddress { get; private set; } = emailAddress;
    public PhoneNumber? PhoneNumber { get; private set; } = phoneNumber;

    public void Rename(EmployeeName employeeName)
    {
        EmployeeName = employeeName;
    }

    public void ChangeEmailAddress(EmailAddress emailAddress)
    {
        EmailAddress = emailAddress;
    }

    public void ChangePhoneNumber(PhoneNumber phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }
}

