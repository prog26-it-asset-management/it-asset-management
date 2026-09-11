namespace ItAssetManagement.Domain.Employees;

public record EmployeeName
{
    public string Value { get; }

    public EmployeeName(string value, int minLength = 2)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Employee name is required.", nameof(value));

        var normalizedValue = value.Trim();

        if (normalizedValue.Length < minLength)
            throw new ArgumentException(
                $"Employee name must contain at least {minLength} characters.",
                nameof(value));

        Value = normalizedValue;
    }

    public override string ToString() => Value;
}
