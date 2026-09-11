using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

public record AddAssetResponse
(
    bool Success,
    Asset? Asset,
    string? Message
);
