namespace ItAssetManagement.Domain.Locations.ValueObjects;

public record LocationCode
{
    public string Value { get; }
    public LocationCode(string value , int minLenght = 6)
    {
        if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Location code is required.", nameof (value));

        var normalizedValue = value.Trim().Replace("-", "");

        if (normalizedValue.Length < minLenght)
            throw new ArgumentException($"Location code must contain at least {minLenght} characters.", nameof(value));

        Value = normalizedValue;
    }
}
