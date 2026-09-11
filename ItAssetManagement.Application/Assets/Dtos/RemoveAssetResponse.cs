using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

public record RemoveAssetResponse
(
    bool Success,
    Asset? Asset,
    string? Message
);

