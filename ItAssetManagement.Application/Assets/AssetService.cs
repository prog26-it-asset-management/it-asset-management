using ItAssetManagement.Application.Assets.Dtos;
using ItAssetManagement.Domain.Assets;
using ItAssetManagement.Infrastructure.Assets.Presistance;

namespace ItAssetManagement.Application.Assets;

public class AssetService(IAssetRepository assetRepository) : IAssetService
{
    public AddAssetResponse AddAsset(AddAssetRequest request)
    {
        try
        {

            var asset = new Asset(request.AssetName);

            if (asset == null)
            {
                return new AddAssetResponse(false, null, "Failed to create asset.");
            }

            var response = new AddAssetResponse(true, asset, null);
            assetRepository.Add(asset);
            return response;
        }

        catch (Exception ex)
        {

            return new AddAssetResponse(false, null, ex.Message);
        }

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
        var getAllResponse = GetAllAssets();
        var assetToRemove = getAllResponse.Assets.FirstOrDefault(a => a.SerialNumber.Value == request.SerialNumber);
        var success = assetRepository.Remove(request.SerialNumber);
        if (!success)
        {
            return new RemoveAssetResponse(false, assetToRemove, "No asset found with provided Serial Number.");
        }

        return new RemoveAssetResponse(true, assetToRemove, null);
    }
}
