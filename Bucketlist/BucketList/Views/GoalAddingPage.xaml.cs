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
   
    public partial class GoalAddingPage : ContentPage
    {       

        public GoalAddingPage()
        {
            InitializeComponent();

            BindingContext = new Goal();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            Goal goal = (Goal)BindingContext;
            if (!string.IsNullOrWhiteSpace(goal.Name))
            {
                await App.GoalsDB.SaveGoalAsync(goal);
            }
            await Navigation.PopModalAsync();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}