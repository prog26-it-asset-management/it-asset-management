using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

internal record GetAllAssetsResponse
(
    bool Success,
    IEnumerable<Asset> Assets,
    string Message
);
