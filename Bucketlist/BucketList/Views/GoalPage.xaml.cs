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
    public partial class GoalPage : ContentPage
    {
        public GoalPage()
        {
            InitializeComponent();
            BackBut.Source = ImageSource.FromResource("BucketList.Images.Arrow_1.png");
            EditBut.Source = ImageSource.FromResource("BucketList.Images.Edit.png");
            DeleteBut.Source = ImageSource.FromResource("BucketList.Images.Delete.png");
            DoneBut.Source = ImageSource.FromResource("BucketList.Images.Done.png");
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Checkpoints_Clicked(object sender, EventArgs e)
        {
            Goal goal = (Goal)BindingContext;
            RoadmapPage checkpointsPage = new RoadmapPage();
            checkpointsPage.BindingContext = goal;
            await Navigation.PushModalAsync(checkpointsPage);
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            Goal goal = (Goal)BindingContext;
            GoalAddingPage goalAddingPage = new GoalAddingPage();
            goalAddingPage.BindingContext = goal;
            await Navigation.PushModalAsync(goalAddingPage);
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            Goal goal = (Goal)BindingContext;
            await App.BucketlistDB.DeleteGoalAsync(goal);
            await Navigation.PopModalAsync();
        }

        private async void Completed_Clicked(object sender, EventArgs e)
        {
            Goal goal = (Goal)BindingContext;
            goal.IsCompleted = true;
            await Navigation.PopModalAsync();
        }
   
    }
}