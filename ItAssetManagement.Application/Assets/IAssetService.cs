using ItAssetManagement.Application.Assets.Dtos;

namespace ItAssetManagement.Application.Assets;

public interface IAssetService
{
    AddAssetResponse AddAsset(AddAssetRequest request);
    GetAllAssetsResponse GetAllAssets();
    RemoveAssetResponse RemoveAsset(RemoveAssetRequest request);
}
