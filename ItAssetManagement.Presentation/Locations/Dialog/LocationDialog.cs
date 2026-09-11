using ItAssetManagement.Application.Locations.Dtos;
using ItAssetManagement.Application.Locations.Services;

namespace ItAssetManagement.Presentation.Locations.Dialog;

internal class LocationDialog(ILocationService locationService) : ILocationDialog
{
    public void ShowLocationDialog()
    {
        Console.Clear();
        Console.WriteLine("#### ADD LOCATION ####");
        InputDialog($"Enter location name: ", out string name);
        InputDialog($"Enter location code: ", out string code);

        var request = new CreateLocationRequest(name, code);

        var location = locationService.CreateLocation(request);

        if (location is not null)
            Console.WriteLine($"Customer '{location.Location.LocationName}' with id '{location.Location.LocationId}' was created!");
        else
            Console.WriteLine($"Unable to create new location");

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
    public void ShowAllLocations()
    {
        var locations = locationService.GetAllLocations();
        Console.Clear();
        Console.WriteLine("#### LOCATIONLIST ####");

        foreach (var location in locations)
        {
            Console.WriteLine($"Name: {location.LocationName}");
            Console.WriteLine($"Id: {location.LocationId}");
            Console.WriteLine($"Location code: {location.LocationCode}");
            Console.WriteLine("-------------------------------");
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
    private static void InputDialog(string text, out string value)
    {
        do
        {
            Console.Write($"{text}");
            value = Console.ReadLine() ?? string.Empty;
            Console.Clear();
        }
        while (string.IsNullOrWhiteSpace(value));
    }
}
