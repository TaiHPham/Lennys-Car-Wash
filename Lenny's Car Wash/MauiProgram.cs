/*
 * Program Author: Tai Pham
 * Assignment: Program 3 - Lenny's Car Wash
 * 
 * Description:
 * Lenny's Car Wash is an interface that allows users to select a car wash package and add-ons, 
 * and generates a receipt with the selected options and total cost.
 */
namespace Lenny_s_Car_Wash;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        return builder.Build();
    }
}
