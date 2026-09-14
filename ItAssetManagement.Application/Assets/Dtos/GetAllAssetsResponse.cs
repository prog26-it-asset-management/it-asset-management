using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

public record GetAllAssetsResponse
(
    bool Success,
    IEnumerable<Asset> Assets,
    string? Message
);
