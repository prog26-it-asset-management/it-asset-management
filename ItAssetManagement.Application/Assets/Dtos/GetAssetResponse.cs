using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

public record GetAssetResponse
(
    bool Success,
    Asset Asset,
    string Message
);
