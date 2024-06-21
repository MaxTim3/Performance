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
    public partial class CategoryAddingPage : ContentPage
    {
        public CategoryAddingPage()
        {
            InitializeComponent();

            BindingContext = new Category();

            BackBut.Source = ImageSource.FromResource("BucketList.Images.Arrow_1.png");
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            Category category = (Category)BindingContext;
            if (!string.IsNullOrWhiteSpace(category.Name))
            {
                await App.BucketlistDB.SaveCategoryAsync(category);
            }
            await Navigation.PopModalAsync();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}