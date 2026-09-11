using ItAssetManagement.Domain.Locations;
using ItAssetManagement.Infrastructure.Locations.Stores;

namespace ItAssetManagement.Infrastructure.Locations.InMemory;

public class InMemoryLocationRepository : ILocationRepository
{
    public bool AddLocation(Location location)
    {
        if (location is null)
            throw new ArgumentNullException("Location is empty and cannot be added.");        
        else
        {
            InMemoryLocationStores.Locations.Add(location);
            return true;
        }

    }

    public IReadOnlyList<Location> GetLocations()
    {
        var locations = InMemoryLocationStores.Locations;
        return locations;
    }
}
