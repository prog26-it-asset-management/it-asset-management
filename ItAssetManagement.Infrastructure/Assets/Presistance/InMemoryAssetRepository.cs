using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Infrastructure.Assets.Presistance;

public class InMemoryAssetRepository : IAssetRepository
{
    private readonly List<Asset> _assets = [];

    public bool Add(Asset asset)
    {
        _assets.Add(asset);
        return true;
    }

    public IEnumerable<Asset> GetAllAssets()
    {
        return _assets;
    }

    public bool Remove(string serialNumber)
    {
        var asset = _assets.FirstOrDefault(a => a.SerialNumber.Value == serialNumber);
        if (asset == null)
        {
            return false;
        }
        _assets.Remove(asset);
        return true;
    }
}
