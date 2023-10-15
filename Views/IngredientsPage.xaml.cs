using PenguinPantry.ViewModels;

namespace PenguinPantry.Views;

public partial class IngredientsPage : ContentPage
{
	public IngredientsPage(IngredientViewModel vm)
	{
		InitializeComponent();
		//foo.ItemsSource = RequestsClient.Ingredients;
		BindingContext = vm;
	}

}

