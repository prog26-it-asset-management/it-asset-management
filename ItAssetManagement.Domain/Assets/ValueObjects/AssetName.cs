namespace ItAssetManagement.Domain.Assets.ValueObjects;

public class AssetName
{
    public string Value { get; }

    public AssetName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
        {
            throw new ArgumentException("Asset name must be at least 3 characters long.", nameof(value));
        }
        Value = value;
    }

    public override string ToString() => Value;
}
