using PenguinPantry.ViewModels;

namespace PenguinPantry.Views;

public partial class IngredientInputPage : ContentPage
{
	public IngredientInputPage(IngredientInputViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}