using PenguinPantry.Views;

namespace PenguinPantry;


public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(IngredientInputPage), typeof(IngredientInputPage));
	}
}
