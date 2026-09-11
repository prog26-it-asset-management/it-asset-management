using ItAssetManagement.Domain.Locations.ValueObjects;

namespace ItAssetManagement.Domain.Locations;

public class Location(LocationName locationName, LocationCode locationCode)
{
    public Guid LocationId { get; init; } = GenerateId();
    public LocationName LocationName { get; private set; } = locationName;
    public LocationCode LocationCode { get; private set; } = locationCode;

    private static Guid GenerateId () => Guid.NewGuid();

    public void LocationNameChange(LocationName name)
    {
        LocationName = name;
    }
    public void LocationCodeChange(LocationCode code)
    {
        LocationCode = code;
    }

}

