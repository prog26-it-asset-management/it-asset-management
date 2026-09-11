namespace ItAssetManagement.Domain.Locations;

public interface ILocationRepository
{
    bool AddLocation(Location location);

    IReadOnlyList<Location> GetLocations();
}
