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
    public class CocktailListViewModel
    {
        private ICocktailService cocktailService;
        private ObservableCollection<Cocktail> cocktails;

        public ObservableCollection<Cocktail> Cocktails
        {
            get { return cocktails; }
        }

        public CocktailListViewModel()
        {
            cocktailService = new CocktailService();
            cocktails = new ObservableCollection<Cocktail>();
        }

        public async void getCocktailDataAsync(string searchName)
        {
            var response = await cocktailService.SearchCocktails(searchName);

            foreach(var cocktail in response.Drinks)
            {
                Debug.WriteLine(cocktail.StrDrink);
                cocktails.Add(cocktail);
            }
        }
    }
}
