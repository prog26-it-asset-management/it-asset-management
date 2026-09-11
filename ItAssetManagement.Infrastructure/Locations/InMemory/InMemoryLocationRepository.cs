using ItAssetManagement.Domain.Locations;

namespace ItAssetManagement.Infrastructure.Locations.InMemory;

public class InMemoryLocationRepository : ILocationRepository
{
    private readonly List<Location> _locations = [];

    public bool AddLocation(Location location)
    {
        if (location is null)
            throw new ArgumentNullException("Location is empty and cannot be added.");        
        else
        {
            _locations.Add(location);
            return true;
        }

    }

    public IReadOnlyList<Location> GetLocations()
    {
        return _locations;
    }
}
