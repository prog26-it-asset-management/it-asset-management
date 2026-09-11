using ItAssetManagement.Domain.Assets;

namespace ItAssetManagement.Application.Assets.Dtos;

public record ChangeAssetStatusRequest(
        string SerialNumber
);
