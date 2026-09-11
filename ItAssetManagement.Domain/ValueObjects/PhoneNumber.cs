namespace ItAssetManagement.Domain.ValueObjects;

public record PhoneNumber
{
    public string Value { get; }

    public PhoneNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Phone number is required.", nameof(value));

        var normalizedValue = value.Trim();

        if (normalizedValue.Length < 7)
            throw new ArgumentException(
                "Phone number must contain at least 7 characters.",
                nameof(value));

        Value = normalizedValue;
    }

    public override string ToString() => Value;
}
