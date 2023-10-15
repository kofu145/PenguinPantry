using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PenguinPantry.Models;

namespace PenguinPantry
{
    public class RequestsClient
    {
        public static readonly HttpClient httpClient;
        public static readonly string Server;
        public static List<string> Ingredients { get; private set; }
        public static List<Recipe> Recipes { get; private set; }

        static RequestsClient()
        {
            httpClient = new HttpClient();
            Server = "http://traptrixden.ddns.net:5698";
            
        }

        public static async void LoadDBs()
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync("ingredients.json");
                using var reader = new StreamReader(stream);

                Ingredients = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());

            }
            catch (Exception ex)
            {
                Debug.WriteLine("error!");
            }

            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync("db-recipes.json");
                using var reader = new StreamReader(stream);

                var recipes = JsonConvert.DeserializeObject<Dictionary<string, Recipe>>(reader.ReadToEnd());
                Recipes = recipes.Values.ToList();
                Debug.WriteLine(Recipes.GetRange(0, 10));

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Dictionary error!");
                Debug.WriteLine(ex.ToString());
            }
        }

        public async static void InputIngredients(List<string> ingredients)
        {
            List<string> inputIngredients = ingredients.ToList();
            inputIngredients.AddRange(ingredients);

            string json = JsonConvert.SerializeObject(inputIngredients.ToArray());
            await System.IO.File.WriteAllTextAsync(FileSystem.Current.AppDataDirectory, "ingredients.json");
        }


    }
}
