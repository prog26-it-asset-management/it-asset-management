using ItAssetManagement.Application.Assets.Dtos;
using ItAssetManagement.Domain.Assets;
using ItAssetManagement.Infrastructure.Assets.Presistance;

namespace ItAssetManagement.Application.Assets;

internal class AssetService(IAssetRepository assetRepository) : IAssetService
{
    public AddAssetResponse AddAsset(AddAssetRequest request)
    {
        var asset = new Asset(request.AssetName);

        if (asset == null)
        {
            return new AddAssetResponse(false, null, "Failed to create asset.");
        }

        var response = new AddAssetResponse(true, asset, null);
        return response;
    }

    public GetAllAssetsResponse GetAllAssets()
    {
        var assets = assetRepository.GetAllAssets();
        if (assets == null)
        {
            return new GetAllAssetsResponse(false, null, "Failed to retrieve assets.");
        }

        return new GetAllAssetsResponse(true, assets, null);
    }

    public RemoveAssetResponse RemoveAsset(RemoveAssetRequest request)
    {
        var success = assetRepository.Remove(request.AssetId);
        if (!success)
        {
            return new RemoveAssetResponse(false, "No asset found with provided Id.");
        }

        return new RemoveAssetResponse(true, null);
    }
}
