using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinPantry.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public int Preptime { get; set; }
        public int Waittime { get; set; }
        public int Cooktime { get; set; }
        public int Servings { get; set; }
        public string Comments { get; set; }
        public int Calories { get; set; }
        public int Fat { get; set; }
        public int Carbs { get; set; }
        public int Fiber { get; set; }
        public int Sugar { get; set; }
        public int Protein { get; set; }
        public string Instructions { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Tags { get; set; }

        
    }
}
