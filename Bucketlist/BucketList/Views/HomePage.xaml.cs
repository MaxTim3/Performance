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
        }
        protected override async void OnAppearing()
        {
            goals.ItemsSource = await App.GoalsDB.GetGoalsAsync();

            base.OnAppearing();
        }
        private async void NewGoal_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GoalAddingPage));
        }

        private async void Goals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.CurrentSelection != null)
            {
                Goal goal = (Goal)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync(
                    $"{ nameof(GoalAddingPage)}?{ nameof(GoalAddingPage.ItemID)}={goal.ID.ToString()}");
            }
        }
    }
}