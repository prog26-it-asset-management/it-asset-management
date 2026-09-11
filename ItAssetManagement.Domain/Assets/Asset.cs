using ItAssetManagement.Domain.Assets.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace ItAssetManagement.Domain.Assets;

public class Asset
{
    public Guid AssetId { get; private set; }
    [MinLength(3)]
    public AssetName AssetName { get; private set; }
    public SerialNumber SerialNumber { get; private set; }
    public EAssetStatus Status { get; private set; }

    public Asset(string assetName)
    {
        AssetId = GenerateAssetId();
        AssetName = new AssetName(assetName);
        SerialNumber = new SerialNumber(AssetName.Value);
        Status = EAssetStatus.Active;
    }


    private Guid GenerateAssetId() => Guid.NewGuid();

    public void Retire()
    {
        if (Status == EAssetStatus.Retired)
        {
            throw new InvalidOperationException("Asset is already retired.");
        }
        Status = EAssetStatus.Retired;
    }
}
