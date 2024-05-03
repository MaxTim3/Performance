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
    [QueryProperty(nameof(ItemID),nameof(ItemID))]

    public partial class GoalAddingPage : ContentPage
    {       
        public string ItemID
        {
           set
           {
               LoadGoal(value);
           }
        }

		public GoalAddingPage ()
		{
			InitializeComponent ();

            BindingContext = new Goal();
		}

        private async void LoadGoal(string value)
        {
            try
            {
                int id = Convert.ToInt32(value);
                Goal goal = await App.GoalsDB.GetGoalAsync(id);
                BindingContext = goal;
            }
            catch { }
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Goal goal = (Goal)BindingContext;
            if (!string.IsNullOrWhiteSpace(goal.Name))
            {
                await App.GoalsDB.SaveGoalAsync(goal);
            }
            await Shell.Current.GoToAsync("..");    
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            Goal goal = (Goal)BindingContext;

            await App.GoalsDB.DeleteGoalAsync(goal);

            await Shell.Current.GoToAsync("..");
        }
    }
}