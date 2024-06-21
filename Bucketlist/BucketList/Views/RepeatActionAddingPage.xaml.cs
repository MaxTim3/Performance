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
    public partial class RepeatActionAddingPage : ContentPage
    {
        public RepeatActionAddingPage()
        {
            InitializeComponent();

            BindingContext = new RepeatAction();

            BackBut.Source = ImageSource.FromResource("BucketList.Images.Arrow_1.png");
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            RepeatAction repeatAction = (RepeatAction)BindingContext;
            if (!string.IsNullOrWhiteSpace(repeatAction.Name))
            {
                await App.BucketlistDB.SaveRepeatActionAsync(repeatAction);
            }
            await Navigation.PopModalAsync();
    
        }
    }
}