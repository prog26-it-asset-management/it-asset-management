using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

public record ChangeAssetStatusResponse
(
    bool Success,
    Asset? Asset,
    string? Message
);
