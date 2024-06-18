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
    public partial class RoadmapPage : ContentPage
    {
        public RoadmapPage()
        {
            InitializeComponent();

            BackBut.Source = ImageSource.FromResource("BucketList.Images.Arrow_1.png");
            PlusBut.Source = ImageSource.FromResource("BucketList.Images.Plus.png");
        }

        protected override async void OnAppearing()
        {
            checkpoints.ItemsSource = await App.GoalsDB.GetGoalsAsync();

            base.OnAppearing();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void NewCheckpoint_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GoalAddingPage());
        }

        private async void Checkpoints_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Goal goal = (Goal)e.CurrentSelection.FirstOrDefault();
            GoalPage goalPage = new GoalPage();
            goalPage.BindingContext = goal;
            await Navigation.PushModalAsync(goalPage);
        }
    }
}