﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailRecipeApp.Models
{
    public class Cocktail
    {
        public string IdDrink { get; set; }
        public string StrDrink{ get; set; }    
        public string StrInstructions { get; set; }
        public string StrDrinkThumb { get; set; }

        public string StrIngredient1 { get; set; }
        public string StrIngredient2 { get; set; }
        public string StrIngredient3 { get; set; }
        public string StrIngredient4 { get; set; }
        public string StrIngredient5 { get; set; }
        
        public string StrMeasure1 { get; set; }
        public string StrMeasure2 { get; set; }
        public string StrMeasure3 { get; set; }
        public string StrMeasure4 { get; set; }
        public string StrMeasure5 { get; set; }
        
    }
}
