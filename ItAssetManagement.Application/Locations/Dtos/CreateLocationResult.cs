using ItAssetManagement.Domain.Locations;

namespace ItAssetManagement.Application.Locations.Dtos;

public record CreateLocationResult
(
    bool Succeeded,
    Location? Location,
    string? ErrorMessage

);

