using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinPantry.ViewModels
{
    public partial class IngredientInputViewModel : ObservableObject
    {
        [ObservableProperty]
        public string inputString;

        [RelayCommand]
        async Task InputIngredient()
        {

            // RequestsClient.InputIngredients();
        }

    }
}
