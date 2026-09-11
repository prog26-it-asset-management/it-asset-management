using System.ComponentModel.DataAnnotations;

namespace ItAssetManagement.Domain.Assets;

public class Asset
{
    public Guid AssetId { get; private set; }
    [MinLength(3)]
    public string AssetName { get; private set; }
    public string SerialNumber { get; private set; }
    public EAssetStatus Status { get; private set; }

    public Asset(string assetName)
    {
        AssetId = GenerateAssetId();
        AssetName = validateAssetName(assetName);
        SerialNumber = GenerateSerialNumber(AssetName);
        Status = EAssetStatus.Active;
    }

    private string validateAssetName(string assetName)
    {
        if (string.IsNullOrWhiteSpace(assetName) || assetName.Length < 3)
        {
            throw new ArgumentException("Asset name must be at least 3 characters long.", nameof(assetName));
        }
        return assetName;
    }

    private Guid GenerateAssetId() => Guid.NewGuid();

    private string GenerateSerialNumber(string assetName)
    {
        var serialNumber = $"{assetName.Substring(0, 3).ToUpper()}-{Guid.NewGuid().ToString().Substring(0, 3).ToUpper()}";
        return serialNumber;
    }

    public void Retire()
    {
        if (Status == EAssetStatus.Retired)
        {
            throw new InvalidOperationException("Asset is already retired.");
        }
        Status = EAssetStatus.Retired;
    }
}
