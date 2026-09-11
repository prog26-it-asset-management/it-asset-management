using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Infrastructure.Assets.Presistance;

internal class InMemoryAssetRepository : IAssetRepository
{
    private readonly List<Asset> _assets = [];

    public bool Add(Asset asset)
    {
        _assets.Add(asset);
        return true;
    }

    public IEnumerable<Asset> GetAll()
    {
        return _assets;
    }

    public bool Remove(Guid assetId)
    {
        var asset = _assets.FirstOrDefault(a => a.AssetId == assetId);
        if (asset == null)
        {
            return false;
        }
        _assets.Remove(asset);
        return true;
    }
}
