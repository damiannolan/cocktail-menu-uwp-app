using CocktailRecipeApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CocktailRecipeApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ICocktailService cocktailService;

        public MainPage()
        {
            this.InitializeComponent();

            cocktailService = new CocktailService();
            
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var response = await cocktailService.SearchCocktails("margarita");

            foreach(var cocktail in response.Drinks)
            {
                Debug.WriteLine(cocktail);
            }
        }
    }
}
