using CocktailRecipeApp.Models;
using CocktailRecipeApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailRecipeApp.ViewModels
{
    public class RandomCocktailViewModel
    {
        private ICocktailService cocktailService;
        private ObservableCollection<Cocktail> cocktails;

        public ObservableCollection<Cocktail> Cocktails
        {
            get { return cocktails; }
        }

        public RandomCocktailViewModel()
        {
            cocktailService = new CocktailService();
            cocktails = new ObservableCollection<Cocktail>();
        }

        public async void getCocktailDataAsync()
        {
            var response = await cocktailService.RandomCocktail();

            if (response.Drinks == null)
            {
                cocktails.Add(new Cocktail("Whoops! Something went wrong!", "We cannot seem to find the recipe you are looking for. Please try again!", "../Images/sadface.png"));
            }
            else
            {
                foreach (var cocktail in response.Drinks)
                {
                    Debug.WriteLine(cocktail.StrDrink);
                    cocktails.Add(cocktail);
                }

            }
        }
    }
}
