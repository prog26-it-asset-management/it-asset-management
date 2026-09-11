using ItAssetManagement.Application.Locations.Dtos;
using ItAssetManagement.Domain.Locations;

namespace ItAssetManagement.Application.Locations.Services;

public interface ILocationService
{
    public CreateLocationResult CreateLocation (CreateLocationRequest request);

    public IReadOnlyList<Location> GetAllLocations();
}
