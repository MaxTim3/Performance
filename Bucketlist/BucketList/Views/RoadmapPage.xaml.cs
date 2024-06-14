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
        }

        /*protected override async void OnAppearing()
        {
            checkpoints.ItemsSource = await App.checkpointsDB.GetCheckpointsAsync();

            base.OnAppearing();
        }*/

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private /*async*/ void NewCheckpoint_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new CheckpointAddingPage());
        }

        private void Checkpoints_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}