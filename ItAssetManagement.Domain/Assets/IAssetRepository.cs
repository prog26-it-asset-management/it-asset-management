using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Infrastructure.Assets.Presistance;

public interface IAssetRepository
{
    bool Add(Asset asset);
    IEnumerable<Asset> GetAll();
    bool Remove(Guid assetId);
}