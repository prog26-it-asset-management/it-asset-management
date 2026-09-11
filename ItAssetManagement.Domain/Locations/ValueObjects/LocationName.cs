namespace ItAssetManagement.Domain.Locations.ValueObjects;

public record LocationName
{
    public string Value { get; }
    public LocationName(string value, int minLenght = 2)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Location name is required.", nameof(value));

        var normalizedValue = value.Trim();

        if (normalizedValue.Length < minLenght)
            throw new ArgumentException($"Location name must contain at least {minLenght} characters.", nameof(value));

        Value = normalizedValue;
    }
    public override string ToString() => Value;
}
