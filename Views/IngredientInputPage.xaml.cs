using PenguinPantry.ViewModels;

namespace PenguinPantry.Views;

public partial class IngredientInputPage : ContentPage
{
	public IngredientInputPage(IngredientInputViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        buttonIngredient.Clicked += ButtonIngredient_Clicked;
	}

    private void ButtonIngredient_Clicked(object sender, EventArgs e)
    {
        DisplayAlert(entryIngredients.Text + "Ingredient added!", "That's a lie. Nothing got added yet.", "Okay cool!");
    }
}