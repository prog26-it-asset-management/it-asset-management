using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Infrastructure.Assets.Presistance;

public interface IAssetRepository
{
    bool Add(Asset asset);
    IEnumerable<Asset> GetAllAssets();
    bool Remove(Guid assetId);
}