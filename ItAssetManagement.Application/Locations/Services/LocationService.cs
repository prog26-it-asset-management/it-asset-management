using ItAssetManagement.Application.Locations.Dtos;
using ItAssetManagement.Domain.Locations;
using ItAssetManagement.Domain.Locations.ValueObjects;

namespace ItAssetManagement.Application.Locations.Services;

public class LocationService(ILocationRepository locationRepository) : ILocationService
{
    public CreateLocationResult CreateLocation(CreateLocationRequest request)
    {
        var locationName = new LocationName(request.LocationName);
        var locationCode = new LocationCode(request.LocationCode);

        var location = new Location(locationName, locationCode);

        locationRepository.AddLocation(location);

        return new CreateLocationResult(true, location, null);
    }

    public IReadOnlyList<Location> GetAllLocations()
    {
        return locationRepository.GetLocations();
    }
}
public interface ILocationService
{
    public CreateLocationResult CreateLocation (CreateLocationRequest request);

    public IReadOnlyList<Location> GetAllLocations();
}
