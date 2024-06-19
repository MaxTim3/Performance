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
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            goals.ItemsSource = await App.BucketlistDB.GetGoalsAsync();

            base.OnAppearing();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            Category category = (Category)BindingContext;
            CategoryAddingPage categoryAddingPage = new CategoryAddingPage();
            categoryAddingPage.BindingContext = category;
            await Navigation.PushModalAsync(categoryAddingPage);
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            Category category = (Category)BindingContext;
            await App.BucketlistDB.DeleteCategoryAsync(category);
            await Navigation.PopModalAsync();
        }

        private async void New_Goal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GoalAddingPage());
        }

        private async void Goals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Goal goal = (Goal)e.CurrentSelection.FirstOrDefault();
            GoalPage goalPage = new GoalPage();
            goalPage.BindingContext = goal;
            await Navigation.PushModalAsync(goalPage);
        }
    }
}