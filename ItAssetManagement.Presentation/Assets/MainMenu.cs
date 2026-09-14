using ItAssetManagement.Presentation.Locations.Dialog;

namespace ItAssetManagement.Presentation.Assets;

internal class MainMenu(LocationMenu locationMenu, IAssetDialog assetDialog)
{
    public void ShowMainMenu()
    {
        var isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the IT Asset Management System");
            Console.WriteLine("1. Asset Management");
            Console.WriteLine("2. Location Management");
            Console.WriteLine("0. Exit");
            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    assetDialog.ShowAssetMenu();
                    break;
                case ConsoleKey.D2:
                    locationMenu.MenuDialog();
                    break;
                case ConsoleKey.D0:
                    isRunning = false;
                    break;
                default:
                    break;
            }
        }
    }
}
