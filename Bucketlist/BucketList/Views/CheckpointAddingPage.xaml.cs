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
    public partial class CheckpointAddingPage : ContentPage
    {
        public CheckpointAddingPage()
        {
            InitializeComponent();

            BindingContext = new Checkpoint();

            BackBut.Source = ImageSource.FromResource("BucketList.Images.Arrow_1.png");
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            Checkpoint checkpoint = (Checkpoint)BindingContext;
            if (!string.IsNullOrWhiteSpace(checkpoint.Name))
            {
                await App.BucketlistDB.SaveCheckpointAsync(checkpoint);
            }
            await Navigation.PopModalAsync();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}