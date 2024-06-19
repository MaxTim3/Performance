using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BucketList.Models;

namespace BucketList.Views
{
    public partial class HomePage : ContentPage
    {

        public HomePage()
        {
            InitializeComponent();

            TxtGreat.Text = "Отлично! \n" + "Так держать!";
        }
        protected override async void OnAppearing()
        {
            goals.ItemsSource = await App.BucketlistDB.GetGoalsAsync();

            base.OnAppearing();
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

        private async void Category_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CategoriesPage());
        }
    }
}