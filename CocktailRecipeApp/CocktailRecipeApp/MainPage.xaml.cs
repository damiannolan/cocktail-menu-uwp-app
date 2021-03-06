﻿using CocktailRecipeApp.Services;
using CocktailRecipeApp.Views;
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
        public string searchName { get; set; }

        private ICocktailService cocktailService;

        public MainPage()
        {
            this.InitializeComponent();

            // Create a ViewModel 
            // Encapsulate this stuff in viewmodel
            cocktailService = new CocktailService();
            
        }

        private void searchCocktailsByName_Click(object sender, RoutedEventArgs e)
        {
            if(searchName != "")
            {
                this.Frame.Navigate(typeof(CocktailsList), searchName);
            }

        }

        private void randomCocktail_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RandomCocktail));
        }
    }
}
