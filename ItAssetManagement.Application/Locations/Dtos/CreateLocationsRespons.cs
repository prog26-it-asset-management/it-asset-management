using ItAssetManagement.Domain.Locations;

namespace ItAssetManagement.Application.Locations.Dtos;

public record CreateLocationsRespons
(
    bool Succeeded,
    IReadOnlyList<Location>? Locations,
    string ErrorMessage
);
