namespace ItAssetManagement.Domain.Assets;

internal class Asset
{
    public Guid AssetId { get; private set; }
    public string AssetName { get; private set; }
    public string SerialNumber { get; private set; }
    public EAssetStatus Status { get; private set; }

}
