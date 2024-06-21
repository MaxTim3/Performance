using BucketList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketList.Views
{
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            categories.ItemsSource = await App.BucketlistDB.GetCategoriesAsync();

            base.OnAppearing();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage());
        }

        private async void New_Category_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CategoryAddingPage());
        }

        private async void Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category category = (Category)e.CurrentSelection.FirstOrDefault();
            CategoryPage categoryPage = new CategoryPage();
            categoryPage.BindingContext = category;
            await Navigation.PushModalAsync(categoryPage);
        }
    }
}