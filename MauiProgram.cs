using PenguinPantry.ViewModels;
using Microsoft.Extensions.Logging;
using PenguinPantry.Views;

namespace PenguinPantry;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<RecipePage>();
		builder.Services.AddSingleton<RecipeViewModel>();

        builder.Services.AddSingleton<IngredientsPage>();
        builder.Services.AddSingleton<IngredientViewModel>();

        builder.Services.AddSingleton<IngredientInputPage>();
        builder.Services.AddSingleton<IngredientInputViewModel>();

		RequestsClient.LoadDBs();

        return builder.Build();
	}
}
