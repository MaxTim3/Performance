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

    public partial class CheckpointPage : ContentPage
    {
        public CheckpointPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            repeatActions.ItemsSource = await App.BucketlistDB.GetRepeatActionsAsync();

            base.OnAppearing();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            Checkpoint checkpoint = (Checkpoint)BindingContext;
            CheckpointAddingPage checkpointAddingPage = new CheckpointAddingPage();
            checkpointAddingPage.BindingContext = checkpoint;
            await Navigation.PushModalAsync(checkpointAddingPage);
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            Checkpoint checkpoint = (Checkpoint)BindingContext;
            await App.BucketlistDB.DeleteCheckpointAsync(checkpoint);
            await Navigation.PopModalAsync();
        }

        private async void New_RepeatAction_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RepeatActionAddingPage());
        }

        private async void RepeatActions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RepeatAction repeatAction = (RepeatAction)e.CurrentSelection.FirstOrDefault();
            RepeatActionPage repeatActionPage = new RepeatActionPage();
            repeatActionPage.BindingContext = repeatAction;
            await Navigation.PushModalAsync(repeatActionPage);
        }

        private async void Completed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}