using ItAssetManagement.Application.Assets;
using ItAssetManagement.Application.Assets.Dtos;

namespace ItAssetManagement.Presentation.Assets;

public class AssetDialog(IAssetService assetService) : IAssetDialog
{
    public void ShowAssetMenu()
    {
        var isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Asset Management Menu");
            Console.WriteLine("1. Add Asset");
            Console.WriteLine("2. View All Assets");
            Console.WriteLine("3. Remove Asset");
            Console.WriteLine("4. Go back to main menu");

            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D1:
                    ShowAddAssetDialog();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    ShowAllAssetsDialog("All Assets");
                    ContinuePrompt();
                    break;
                case ConsoleKey.D3:
                    ShowRemoveAssetDialog();
                    break;
                case ConsoleKey.D4:
                    isRunning = false;
                    break;
                default:
                    break;
            }

        }
    }
    private void ShowAddAssetDialog()
    {
        Console.Clear();
        Console.WriteLine("*** Add Asset ***");
        Console.Write("Input Asset Name:");
        var assetName = Console.ReadLine();

        var request = new AddAssetRequest(assetName!);
        var response = assetService.AddAsset(request);

        if (response.Success)
        {
            Console.Clear();
            Console.WriteLine($"Asset {assetName} added successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to add asset: {response.Message}");
        }

        ContinuePrompt();
    }

    private void ShowAllAssetsDialog(string title)
    {
        Console.WriteLine($"*** {title} ***");

        var response = assetService.GetAllAssets();

        if (!response.Success)
        {
            Console.WriteLine($"Failed to retrieve assets: {response.Message}");
            ContinuePrompt();
            return;
        }

        if (!response.Assets.Any())
        {
            Console.WriteLine("No assets found.");
            ContinuePrompt();
            return;
        }

        foreach (var asset in response.Assets)
        {
            if (asset == null) continue;
            Console.WriteLine($"Asset ID: {asset.SerialNumber}, Asset Name: {asset.AssetName}, Current status {asset.Status}");
            Console.WriteLine("********************************");
        }
    }

    private void ShowRemoveAssetDialog()
    {
        Console.Clear();
        Console.WriteLine("*** Remove Asset ***");
        ShowAllAssetsDialog("Current Assets");

        Console.Write("Input Asset Serial Number (ABC-123) to remove:");
        var serialNumber = Console.ReadLine();

        var request = new RemoveAssetRequest(serialNumber!);
        var response = assetService.RemoveAsset(request);

        if (response.Success)
        {
            Console.WriteLine($"Asset {response.Asset?.SerialNumber} removed successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to remove asset: {response.Message}");
        }

        ContinuePrompt();
    }

    private static void ContinuePrompt()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}
