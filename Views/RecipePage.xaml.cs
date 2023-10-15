using PenguinPantry.ViewModels;

namespace PenguinPantry.Views;

public partial class RecipePage : ContentPage
{
    public RecipePage(RecipeViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}