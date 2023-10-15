using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PenguinPantry.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinPantry.ViewModels
{
    public partial class RecipeViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Recipe> recipes;

        public RecipeViewModel()
        {
            Recipes = new ObservableCollection<Recipe>(RequestsClient.Recipes.GetRange(0, 10));
            GetRecipes();
        }

        [RelayCommand]
        async Task GetRecipes()
        {
            List<Recipe> recipesCanCook = new List<Recipe>();
            if (!(RequestsClient.Ingredients.Count < 10))
            {

                while (recipesCanCook.Count() < 10)
                {
                    for (int i = 0; i < RequestsClient.Recipes.Count; i++)
                    {
                        bool canCook = true;
                        foreach (string ingredient in RequestsClient.Ingredients)
                        {
                            if (!RequestsClient.Recipes[i].Ingredients.Contains(ingredient))
                            {
                                canCook = false;
                                break;
                            }
                        }
                        if (canCook)
                        {
                            recipesCanCook.Add(RequestsClient.Recipes[i]);
                        }
                    }
                }
                Recipes = new ObservableCollection<Recipe>(recipesCanCook);
            }
        }

        [RelayCommand]
        async Task ViewRecipeCommand()
        {
            //Shell.Current.GoToAsync(nameof());
        }

    }
}
