using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

internal record GetAssetResponse
(
    bool Success,
    Asset Asset,
    string Message
);
