namespace ItAssetManagement.Presentation.Locations.Dialog;

internal class LocationMenu(ILocationDialog locationDialog)
{
    private bool _isRunning = true;
    public void MenuDialog()
    {
        do
        {
            Console.WriteLine("#### LOCATIONMENU ####");
            Console.WriteLine("[1] Add Location");
            Console.WriteLine("[2] View All ");
            Console.WriteLine("[0] Quit");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    locationDialog.ShowLocationDialog();

                    break;
                case "2":
                    locationDialog.ShowAllLocations();
                    break;
                case "0":
                    _isRunning = false;
                    break;
                default:
                    Console.WriteLine("You must enter a valid option!");
                    Console.ReadKey();
                    break;
            }

        }
        while (_isRunning);
    }
}
